using Bogus;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;
using SubScriberRaffle.Models;
using SubScriberRaffle.UserControls;
using System.IO;
using System.Text;

namespace SubScriberRaffle;

public partial class frmMain : Form
{
    private readonly Image defaultPP;
    private List<UserProfileDetail> users;
    private readonly List<ProfileViewer> profileList;

    private int profileRefreshMilliseconds;
    private int randomizeMillisecond;


    public frmMain()
    {
        InitializeComponent();
        SetTitleBar();

        profileList = new List<ProfileViewer>();

        defaultPP = Image.FromFile(@$"c:\default.png");

        lblUserCount.Text = "";
    }


    private async void btnLoadData_Click(object sender, EventArgs e)
    {
        users = await YoutubeDataProvider.Get(chUseDummyData.Checked, chFromLocalFile.Checked);

        users.ForEach(async (i) => await i.DownloadImageAndSet());
        lblUserCount.Text = $"{users.Count} comments loaded";

        btnStart.Enabled = users.Count > 0;
    }

    // returns Tuple<UserProfileDetail, int>
    private (UserProfileDetail, int) GetRandomUser()
    {
        if (!users.Any(i => !i.IsSelected))
            return (null, 0);

        UserProfileDetail user;
        int randomIndex;

        do
        {
            randomIndex = new Random().Next(0, users.Count);
            user = users[randomIndex];

        } while (user.IsSelected);

        return (user, randomIndex);
    }

    private async Task SetProfileInfo(ProfileViewer profile, int milliseconds, int order)
    {
        UserProfileDetail randomUser = null;
        while (milliseconds > -1)
        {
            await Task.Delay(profileRefreshMilliseconds);
            milliseconds -= profileRefreshMilliseconds;

            (randomUser, int userIndex) = GetRandomUser();

            profile.UpdateInfo(order,
                               randomUser.Image,
                               randomUser.UserName,
                               randomUser.Comment,
                               userIndex);
        }

        randomUser.IsSelected = true;
        profile.Completed = true;
    }

    private async void btnStart_Click(object sender, EventArgs e)
    {
        if (numericUserCount.Value > users.Count)
        {
            MessageBox.Show("Value cannot be greater then user count");
            return;
        }

        if (flowPanel.Controls.Count > 0)
        {
            DialogResult res = MessageBox.Show("Board will be cleared. Are you sure?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (res != DialogResult.Yes)
                return;
        }

        randomizeMillisecond = (int)numericSec.Value * 1000;
        profileRefreshMilliseconds = (int)numericMilliSec.Value;

        ClearBoard();

        for (int i = 0; i < numericUserCount.Value; i++)
        {
            var profile = CreateProfile();

            flowPanel.Controls.Add(profile);
            flowPanel.ScrollControlIntoView(profile);

            profile.SetActive(true);
            await SetProfileInfo(profile, randomizeMillisecond, i + 1);
            profile.SetActive(false);
        }

        btnSaveResults.Enabled = flowPanel.Controls.Count > 0;
    }









    private async void btnSaveResults_Click(object sender, EventArgs e)
    {
        var userNames = new StringBuilder();

        foreach (Control control in flowPanel.Controls)
        {
            if (control is not ProfileViewer profile)
                continue;

            userNames.AppendFormat($"{profile.lblOrder.Text} - {profile.lblName.Text}");
            userNames.AppendLine();
        }

        if (userNames.Length <= 0)
            return;

        string dirName = "Results";
        Directory.CreateDirectory(dirName);
        string filePath = Path.Combine(dirName, $"Result_{DateTime.Now:HHmmss}.txt");
        await File.WriteAllTextAsync(filePath, userNames.ToString());

        MessageBox.Show("Results have been successfully saved!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private ProfileViewer CreateProfile()
    {
        var viewer = new ProfileViewer(defaultPP);
        profileList.Add(viewer);
        return viewer;
    }


    private void ClearBoard()
    {
        try
        {
            flowPanel.SuspendLayout();
            flowPanel.Controls.Clear();
        }
        finally
        {
            flowPanel.ResumeLayout();
        }
    }

    private void chFromLocalFile_CheckedChanged(object sender, EventArgs e)
    {
        if (chFromLocalFile.Checked)
            chUseDummyData.Checked = false;
    }


    #region TitleBar Methods

    private bool drag = false;
    private Point startPoint = new(0, 0);

    private void Control_MouseEnter(object sender, EventArgs e)
    {
        lblClose.ForeColor = Color.White;
    }

    private void Control_MouseLeave(object sender, EventArgs e)
    {
        lblClose.ForeColor = Color.Black;
    }

    private void Control_MouseClick(object sender, MouseEventArgs e)
    {
        Close();
    }

    private void Title_MouseUp(object sender, MouseEventArgs e)
    {
        drag = false;
    }

    private void Title_MouseDown(object sender, MouseEventArgs e)
    {
        startPoint = e.Location;
        drag = true;
    }

    private void Title_MouseMove(object sender, MouseEventArgs e)
    {
        if (drag)
        {
            Point p1 = new Point(e.X, e.Y);
            Point p2 = PointToScreen(p1);
            Point p3 = new Point(p2.X - startPoint.X,
                                 p2.Y - startPoint.Y);
            Location = p3;
        }
    }

    private void SetTitleBar()
    {
        FormBorderStyle = FormBorderStyle.None;

        BackColor = ColorTranslator.FromHtml("#0b141a");

        lblClose.MouseEnter += new EventHandler(Control_MouseEnter);
        lblClose.MouseLeave += new EventHandler(Control_MouseLeave);
        lblClose.MouseClick += new MouseEventHandler(Control_MouseClick);

        pnlTitle.MouseDown += new MouseEventHandler(Title_MouseDown);
        pnlTitle.MouseUp += new MouseEventHandler(Title_MouseUp);
        pnlTitle.MouseMove += new MouseEventHandler(Title_MouseMove);
    }

    #endregion
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubScriberRaffle.UserControls;
public partial class ProfileViewer : UserControl
{
    public bool Completed { get; set; }

    private string fullComment;
    private const int commentLength = 50;

    public ProfileViewer(Image defaultPP)
    {
        InitializeComponent();
        pbProfile.Image = defaultPP;
        lblComment.Text = "";
        lblName.Text = "";
    }

    public void UpdateInfo(int order, Image image, string name, string comment, int userIndex)
    {
        lblOrder.Text = order.ToString();
        pbProfile.Image = image;
        lblName.Text = name;
        lblComment.Text = comment.Length > commentLength ? comment[..commentLength] + "..." : comment;
        lblUserIndex.Text = userIndex.ToString();

        fullComment = comment;
    }

    public void SetActive(bool isActive)
    { 
        if (isActive)
        {
            BackColor = Color.Gray;
        }
        else
        {
            BackColor = Color.Gray;
            lblComment.ForeColor = 
                lblName.ForeColor =
                lblOrder.ForeColor =
                lblUserIndex.ForeColor =
                    Color.Black;
        }
    }

    private void lblComment_DoubleClick(object sender, EventArgs e)
    {
        MessageBox.Show(fullComment);
    }
}

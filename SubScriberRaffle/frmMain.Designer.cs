namespace SubScriberRaffle;

partial class frmMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.numericUserCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRaffleConfiguration = new System.Windows.Forms.GroupBox();
            this.chFromLocalFile = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericMilliSec = new System.Windows.Forms.NumericUpDown();
            this.numericSec = new System.Windows.Forms.NumericUpDown();
            this.lblUserCount = new System.Windows.Forms.Label();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.chUseDummyData = new System.Windows.Forms.CheckBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUserCount)).BeginInit();
            this.cbRaffleConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMilliSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSec)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Enabled = false;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(234, 84);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(211, 30);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Main User List";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoadData.ForeColor = System.Drawing.Color.Snow;
            this.btnLoadData.Location = new System.Drawing.Point(768, 26);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(182, 64);
            this.btnLoadData.TabIndex = 3;
            this.btnLoadData.Text = "Load User Data";
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // flowPanel
            // 
            this.flowPanel.AutoScroll = true;
            this.flowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(75)))));
            this.flowPanel.BackgroundImage = global::SubScriberRaffle.Properties.Resources.AppBG;
            this.flowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanel.Location = new System.Drawing.Point(0, 199);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(956, 881);
            this.flowPanel.TabIndex = 2;
            // 
            // numericUserCount
            // 
            this.numericUserCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.numericUserCount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUserCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUserCount.Location = new System.Drawing.Point(67, 83);
            this.numericUserCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUserCount.Name = "numericUserCount";
            this.numericUserCount.Size = new System.Drawing.Size(133, 30);
            this.numericUserCount.TabIndex = 5;
            this.numericUserCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(13, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Count";
            // 
            // cbRaffleConfiguration
            // 
            this.cbRaffleConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(75)))));
            this.cbRaffleConfiguration.BackgroundImage = global::SubScriberRaffle.Properties.Resources.AppBG;
            this.cbRaffleConfiguration.Controls.Add(this.chFromLocalFile);
            this.cbRaffleConfiguration.Controls.Add(this.label3);
            this.cbRaffleConfiguration.Controls.Add(this.label2);
            this.cbRaffleConfiguration.Controls.Add(this.numericMilliSec);
            this.cbRaffleConfiguration.Controls.Add(this.numericSec);
            this.cbRaffleConfiguration.Controls.Add(this.lblUserCount);
            this.cbRaffleConfiguration.Controls.Add(this.btnSaveResults);
            this.cbRaffleConfiguration.Controls.Add(this.numericUserCount);
            this.cbRaffleConfiguration.Controls.Add(this.chUseDummyData);
            this.cbRaffleConfiguration.Controls.Add(this.label1);
            this.cbRaffleConfiguration.Controls.Add(this.btnStart);
            this.cbRaffleConfiguration.Controls.Add(this.btnLoadData);
            this.cbRaffleConfiguration.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbRaffleConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRaffleConfiguration.ForeColor = System.Drawing.Color.Snow;
            this.cbRaffleConfiguration.Location = new System.Drawing.Point(0, 33);
            this.cbRaffleConfiguration.Name = "cbRaffleConfiguration";
            this.cbRaffleConfiguration.Size = new System.Drawing.Size(956, 166);
            this.cbRaffleConfiguration.TabIndex = 7;
            this.cbRaffleConfiguration.TabStop = false;
            this.cbRaffleConfiguration.Text = "Raffle Configuration";
            // 
            // chFromLocalFile
            // 
            this.chFromLocalFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chFromLocalFile.AutoSize = true;
            this.chFromLocalFile.BackColor = System.Drawing.Color.Transparent;
            this.chFromLocalFile.ForeColor = System.Drawing.Color.Snow;
            this.chFromLocalFile.Location = new System.Drawing.Point(602, 56);
            this.chFromLocalFile.Name = "chFromLocalFile";
            this.chFromLocalFile.Size = new System.Drawing.Size(131, 24);
            this.chFromLocalFile.TabIndex = 17;
            this.chFromLocalFile.Text = "From Local File";
            this.chFromLocalFile.UseVisualStyleBackColor = false;
            this.chFromLocalFile.CheckedChanged += new System.EventHandler(this.chFromLocalFile_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(234, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "MilliSec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sec";
            // 
            // numericMilliSec
            // 
            this.numericMilliSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.numericMilliSec.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericMilliSec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericMilliSec.Location = new System.Drawing.Point(312, 39);
            this.numericMilliSec.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericMilliSec.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericMilliSec.Name = "numericMilliSec";
            this.numericMilliSec.Size = new System.Drawing.Size(133, 30);
            this.numericMilliSec.TabIndex = 14;
            this.numericMilliSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericMilliSec.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericSec
            // 
            this.numericSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.numericSec.DecimalPlaces = 1;
            this.numericSec.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericSec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericSec.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericSec.Location = new System.Drawing.Point(67, 39);
            this.numericSec.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericSec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericSec.Name = "numericSec";
            this.numericSec.Size = new System.Drawing.Size(133, 30);
            this.numericSec.TabIndex = 13;
            this.numericSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericSec.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblUserCount
            // 
            this.lblUserCount.AutoSize = true;
            this.lblUserCount.BackColor = System.Drawing.Color.Transparent;
            this.lblUserCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserCount.ForeColor = System.Drawing.Color.DarkRed;
            this.lblUserCount.Location = new System.Drawing.Point(18, 130);
            this.lblUserCount.Name = "lblUserCount";
            this.lblUserCount.Size = new System.Drawing.Size(165, 20);
            this.lblUserCount.TabIndex = 12;
            this.lblUserCount.Text = "225 comments loaded";
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveResults.Enabled = false;
            this.btnSaveResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveResults.Location = new System.Drawing.Point(768, 117);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(182, 33);
            this.btnSaveResults.TabIndex = 11;
            this.btnSaveResults.Text = "Save Results To File";
            this.btnSaveResults.UseVisualStyleBackColor = true;
            this.btnSaveResults.Click += new System.EventHandler(this.btnSaveResults_Click);
            // 
            // chUseDummyData
            // 
            this.chUseDummyData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chUseDummyData.AutoSize = true;
            this.chUseDummyData.BackColor = System.Drawing.Color.Transparent;
            this.chUseDummyData.Checked = true;
            this.chUseDummyData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chUseDummyData.ForeColor = System.Drawing.Color.Snow;
            this.chUseDummyData.Location = new System.Drawing.Point(602, 26);
            this.chUseDummyData.Name = "chUseDummyData";
            this.chUseDummyData.Size = new System.Drawing.Size(147, 24);
            this.chUseDummyData.TabIndex = 10;
            this.chUseDummyData.Text = "Use Dummy Data";
            this.chUseDummyData.UseVisualStyleBackColor = false;
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.ForeColor = System.Drawing.Color.Black;
            this.lblClose.Location = new System.Drawing.Point(928, 8);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(18, 20);
            this.lblClose.TabIndex = 9;
            this.lblClose.Text = "X";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.ForeColor = System.Drawing.Color.Snow;
            this.lblTitle.Location = new System.Drawing.Point(3, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 20);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Tech Buddy 5000 Sub Raffle";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(132)))));
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.lblClose);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(956, 33);
            this.pnlTitle.TabIndex = 13;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(20)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(956, 1080);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.cbRaffleConfiguration);
            this.Controls.Add(this.pnlTitle);
            this.DoubleBuffered = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.numericUserCount)).EndInit();
            this.cbRaffleConfiguration.ResumeLayout(false);
            this.cbRaffleConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMilliSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSec)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private Button btnStart;
    private Button btnLoadData;
    private FlowLayoutPanel flowPanel;
    private NumericUpDown numericUserCount;
    private Label label1;
    private GroupBox cbRaffleConfiguration;
    private CheckBox chUseDummyData;
    private Button btnSaveResults;
    private Label lblUserCount;
    private Label label3;
    private Label label2;
    private NumericUpDown numericMilliSec;
    private NumericUpDown numericSec;
    private Label lblClose;
    private Label lblTitle;
    private Panel pnlTitle;
    private CheckBox chFromLocalFile;
}

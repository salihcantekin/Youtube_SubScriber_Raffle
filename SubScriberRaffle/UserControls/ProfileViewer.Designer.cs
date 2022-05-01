namespace SubScriberRaffle.UserControls;

partial class ProfileViewer
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileViewer));
            this.lblName = new System.Windows.Forms.Label();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.lblUserIndex = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPicture = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblOrder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPicture.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(179, 41);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Salih Cantekin";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbProfile
            // 
            this.pbProfile.BackColor = System.Drawing.Color.Transparent;
            this.pbProfile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbProfile.Image = ((System.Drawing.Image)(resources.GetObject("pbProfile.Image")));
            this.pbProfile.Location = new System.Drawing.Point(0, 0);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(179, 53);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbProfile.TabIndex = 3;
            this.pbProfile.TabStop = false;
            // 
            // lblUserIndex
            // 
            this.lblUserIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserIndex.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserIndex.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblUserIndex.Location = new System.Drawing.Point(0, 0);
            this.lblUserIndex.Name = "lblUserIndex";
            this.lblUserIndex.Size = new System.Drawing.Size(179, 37);
            this.lblUserIndex.TabIndex = 5;
            this.lblUserIndex.Text = "0";
            this.lblUserIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUserIndex.UseCompatibleTextRendering = true;
            // 
            // lblComment
            // 
            this.lblComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblComment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComment.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblComment.Location = new System.Drawing.Point(0, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(179, 87);
            this.lblComment.TabIndex = 4;
            this.lblComment.Text = "Comment";
            this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblComment.DoubleClick += new System.EventHandler(this.lblComment_DoubleClick);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.panel4);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.pnlPicture);
            this.pnlMain.Controls.Add(this.panel6);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(179, 271);
            this.pnlMain.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUserIndex);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 37);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblComment);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 147);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 87);
            this.panel4.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 41);
            this.panel1.TabIndex = 9;
            // 
            // pnlPicture
            // 
            this.pnlPicture.Controls.Add(this.pbProfile);
            this.pnlPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPicture.Location = new System.Drawing.Point(0, 53);
            this.pnlPicture.Name = "pnlPicture";
            this.pnlPicture.Size = new System.Drawing.Size(179, 53);
            this.pnlPicture.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblOrder);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(179, 53);
            this.panel6.TabIndex = 11;
            // 
            // lblOrder
            // 
            this.lblOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblOrder.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblOrder.Location = new System.Drawing.Point(0, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(179, 53);
            this.lblOrder.TabIndex = 0;
            this.lblOrder.Text = "0";
            this.lblOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfileViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.pnlMain);
            this.DoubleBuffered = true;
            this.Name = "ProfileViewer";
            this.Size = new System.Drawing.Size(179, 271);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlPicture.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion
    private PictureBox pbProfile;
    private Label lblComment;
    private Label lblUserIndex;
    private Panel pnlMain;
    private Panel panel2;
    private Panel panel4;
    private Panel panel1;
    private Panel pnlPicture;
    private Panel panel6;
    public Label lblName;
    public Label lblOrder;
}

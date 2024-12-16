namespace SoftwareEngineering_2024
{
    partial class Admin_log_in
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_log_in));
            WelcomeBackLogin = new Label();
            panel1 = new Panel();
            IgLink = new PictureBox();
            GmapLink = new PictureBox();
            FbLink = new PictureBox();
            AdminPasswordLb = new Label();
            AdminEmailLb = new Label();
            AdminLoginBt = new Button();
            password_txt = new MaskedTextBox();
            email_txt = new MaskedTextBox();
            TCLogo = new PictureBox();
            oracleCommand1 = new Oracle.ManagedDataAccess.Client.OracleCommand();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TCLogo).BeginInit();
            SuspendLayout();
            // 
            // WelcomeBackLogin
            // 
            WelcomeBackLogin.AutoSize = true;
            WelcomeBackLogin.BackColor = Color.RosyBrown;
            WelcomeBackLogin.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WelcomeBackLogin.Location = new Point(266, 25);
            WelcomeBackLogin.Name = "WelcomeBackLogin";
            WelcomeBackLogin.Size = new Size(173, 25);
            WelcomeBackLogin.TabIndex = 0;
            WelcomeBackLogin.Text = "Welcome Admin!";
            WelcomeBackLogin.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(IgLink);
            panel1.Controls.Add(GmapLink);
            panel1.Controls.Add(FbLink);
            panel1.Controls.Add(AdminPasswordLb);
            panel1.Controls.Add(AdminEmailLb);
            panel1.Controls.Add(AdminLoginBt);
            panel1.Controls.Add(password_txt);
            panel1.Controls.Add(email_txt);
            panel1.Controls.Add(WelcomeBackLogin);
            panel1.Location = new Point(824, 46);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 385);
            panel1.TabIndex = 3;
            // 
            // IgLink
            // 
            IgLink.BackgroundImage = (Image)resources.GetObject("IgLink.BackgroundImage");
            IgLink.BackgroundImageLayout = ImageLayout.Stretch;
            IgLink.Cursor = Cursors.Hand;
            IgLink.Location = new Point(483, 315);
            IgLink.Margin = new Padding(3, 2, 3, 2);
            IgLink.Name = "IgLink";
            IgLink.Size = new Size(38, 32);
            IgLink.TabIndex = 9;
            IgLink.TabStop = false;
            // 
            // GmapLink
            // 
            GmapLink.BackgroundImage = Properties.Resources.Gmaps;
            GmapLink.BackgroundImageLayout = ImageLayout.Stretch;
            GmapLink.Cursor = Cursors.Hand;
            GmapLink.Location = new Point(332, 315);
            GmapLink.Margin = new Padding(3, 2, 3, 2);
            GmapLink.Name = "GmapLink";
            GmapLink.Size = new Size(38, 32);
            GmapLink.TabIndex = 8;
            GmapLink.TabStop = false;
            // 
            // FbLink
            // 
            FbLink.BackgroundImage = Properties.Resources.fb;
            FbLink.BackgroundImageLayout = ImageLayout.Stretch;
            FbLink.Cursor = Cursors.Hand;
            FbLink.Location = new Point(188, 315);
            FbLink.Margin = new Padding(3, 2, 3, 2);
            FbLink.Name = "FbLink";
            FbLink.Size = new Size(38, 32);
            FbLink.TabIndex = 7;
            FbLink.TabStop = false;
            // 
            // AdminPasswordLb
            // 
            AdminPasswordLb.AutoSize = true;
            AdminPasswordLb.Location = new Point(98, 164);
            AdminPasswordLb.Name = "AdminPasswordLb";
            AdminPasswordLb.Size = new Size(96, 15);
            AdminPasswordLb.TabIndex = 5;
            AdminPasswordLb.Text = "Admin Password";
            // 
            // AdminEmailLb
            // 
            AdminEmailLb.AutoSize = true;
            AdminEmailLb.Location = new Point(98, 98);
            AdminEmailLb.Name = "AdminEmailLb";
            AdminEmailLb.Size = new Size(80, 15);
            AdminEmailLb.TabIndex = 4;
            AdminEmailLb.Text = "Admin E-Mail";
            // 
            // AdminLoginBt
            // 
            AdminLoginBt.BackColor = Color.IndianRed;
            AdminLoginBt.Location = new Point(266, 243);
            AdminLoginBt.Margin = new Padding(3, 2, 3, 2);
            AdminLoginBt.Name = "AdminLoginBt";
            AdminLoginBt.Size = new Size(172, 43);
            AdminLoginBt.TabIndex = 3;
            AdminLoginBt.Text = "Login";
            AdminLoginBt.TextImageRelation = TextImageRelation.TextAboveImage;
            AdminLoginBt.UseVisualStyleBackColor = false;
            AdminLoginBt.Click += AdminLoginBt_Click;
            // 
            // password_txt
            // 
            password_txt.Location = new Point(98, 181);
            password_txt.Margin = new Padding(3, 2, 3, 2);
            password_txt.Name = "password_txt";
            password_txt.Size = new Size(493, 23);
            password_txt.TabIndex = 2;
            // 
            // email_txt
            // 
            email_txt.Location = new Point(98, 115);
            email_txt.Margin = new Padding(3, 2, 3, 2);
            email_txt.Name = "email_txt";
            email_txt.Size = new Size(493, 23);
            email_txt.TabIndex = 1;
            // 
            // TCLogo
            // 
            TCLogo.BackColor = Color.Transparent;
            TCLogo.BackgroundImage = (Image)resources.GetObject("TCLogo.BackgroundImage");
            TCLogo.BackgroundImageLayout = ImageLayout.Stretch;
            TCLogo.Location = new Point(56, 46);
            TCLogo.Margin = new Padding(3, 2, 3, 2);
            TCLogo.Name = "TCLogo";
            TCLogo.Size = new Size(488, 385);
            TCLogo.TabIndex = 2;
            TCLogo.TabStop = false;
            // 
            // oracleCommand1
            // 
            oracleCommand1.Transaction = null;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(283, 360);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(143, 15);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Not an admin?? click here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Admin_log_in
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot_2024_10_25_103648;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1611, 478);
            Controls.Add(panel1);
            Controls.Add(TCLogo);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin_log_in";
            Text = "Admin_log_in";
            Load += Admin_log_in_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IgLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)GmapLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)FbLink).EndInit();
            ((System.ComponentModel.ISupportInitialize)TCLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label WelcomeBackLogin;
        private Panel panel1;
        private PictureBox IgLink;
        private PictureBox GmapLink;
        private PictureBox FbLink;
        private Label AdminPasswordLb;
        private Label AdminEmailLb;
        private Button AdminLoginBt;
        private MaskedTextBox password_txt;
        private MaskedTextBox email_txt;
        private PictureBox TCLogo;
        private Oracle.ManagedDataAccess.Client.OracleCommand oracleCommand1;
        private LinkLabel linkLabel1;
    }
}
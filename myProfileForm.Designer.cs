namespace myKSU_v3
{
    partial class myProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myProfileForm));
            profile_mainPnl = new Panel();
            chatbot_mainPnl = new Panel();
            chatbot_topPnl = new Panel();
            chatbot_exitLbl = new Label();
            chatbot_helpLbl = new Label();
            chatbot_replyPnl = new Panel();
            chatbot_replyText = new TextBox();
            chatbot_replyPic = new PictureBox();
            label4 = new Label();
            chatbot_askBtn = new Button();
            chatbot_questionTextBox = new TextBox();
            chatbot_greetLbl = new Label();
            chatbot_owlPic = new PictureBox();
            charges_helpBtn = new Button();
            charges_backBtn = new Button();
            profile_editModeLbl = new Label();
            profile_namePicPnl = new Panel();
            label1 = new Label();
            profile_editPicLink = new Label();
            profile_majorLbl = new Label();
            profile_standingLbl = new Label();
            profile_nameLbl = new Label();
            profile_imgPic = new PictureBox();
            profile_textPnl = new Panel();
            profile_saveBtn = new Button();
            profile_editProfileBtn = new Button();
            profile_bioLbl = new Label();
            profile_bioText = new TextBox();
            profile_titlePnl = new Panel();
            profile_titleIcon = new PictureBox();
            profile_titleLbl = new Label();
            profile_miscPnl = new Panel();
            profile_quoteLbl = new Label();
            profile_interestsLbl = new Label();
            profile_quoteText = new TextBox();
            profile_websiteLbl = new Label();
            profile_interestsText = new TextBox();
            profile_websiteText = new TextBox();
            profile_mainPnl.SuspendLayout();
            chatbot_mainPnl.SuspendLayout();
            chatbot_topPnl.SuspendLayout();
            chatbot_replyPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_replyPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatbot_owlPic).BeginInit();
            profile_namePicPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profile_imgPic).BeginInit();
            profile_textPnl.SuspendLayout();
            profile_titlePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profile_titleIcon).BeginInit();
            profile_miscPnl.SuspendLayout();
            SuspendLayout();
            // 
            // profile_mainPnl
            // 
            profile_mainPnl.BackgroundImage = (Image)resources.GetObject("profile_mainPnl.BackgroundImage");
            profile_mainPnl.Controls.Add(chatbot_mainPnl);
            profile_mainPnl.Controls.Add(chatbot_owlPic);
            profile_mainPnl.Controls.Add(charges_helpBtn);
            profile_mainPnl.Controls.Add(charges_backBtn);
            profile_mainPnl.Controls.Add(profile_editModeLbl);
            profile_mainPnl.Controls.Add(profile_namePicPnl);
            profile_mainPnl.Controls.Add(profile_textPnl);
            profile_mainPnl.Controls.Add(profile_titlePnl);
            profile_mainPnl.Controls.Add(profile_miscPnl);
            profile_mainPnl.Dock = DockStyle.Fill;
            profile_mainPnl.Location = new Point(0, 0);
            profile_mainPnl.Name = "profile_mainPnl";
            profile_mainPnl.Size = new Size(521, 699);
            profile_mainPnl.TabIndex = 2;
            // 
            // chatbot_mainPnl
            // 
            chatbot_mainPnl.BackColor = Color.LightYellow;
            chatbot_mainPnl.BorderStyle = BorderStyle.FixedSingle;
            chatbot_mainPnl.Controls.Add(chatbot_topPnl);
            chatbot_mainPnl.Controls.Add(chatbot_replyPnl);
            chatbot_mainPnl.Controls.Add(chatbot_askBtn);
            chatbot_mainPnl.Controls.Add(chatbot_questionTextBox);
            chatbot_mainPnl.Controls.Add(chatbot_greetLbl);
            chatbot_mainPnl.Location = new Point(94, 484);
            chatbot_mainPnl.Name = "chatbot_mainPnl";
            chatbot_mainPnl.Size = new Size(340, 186);
            chatbot_mainPnl.TabIndex = 45;
            chatbot_mainPnl.Visible = false;
            // 
            // chatbot_topPnl
            // 
            chatbot_topPnl.BackColor = Color.Gold;
            chatbot_topPnl.BorderStyle = BorderStyle.FixedSingle;
            chatbot_topPnl.Controls.Add(chatbot_exitLbl);
            chatbot_topPnl.Controls.Add(chatbot_helpLbl);
            chatbot_topPnl.Dock = DockStyle.Top;
            chatbot_topPnl.Location = new Point(0, 0);
            chatbot_topPnl.Name = "chatbot_topPnl";
            chatbot_topPnl.Size = new Size(338, 24);
            chatbot_topPnl.TabIndex = 35;
            // 
            // chatbot_exitLbl
            // 
            chatbot_exitLbl.AutoSize = true;
            chatbot_exitLbl.Location = new Point(311, 2);
            chatbot_exitLbl.Name = "chatbot_exitLbl";
            chatbot_exitLbl.Size = new Size(18, 20);
            chatbot_exitLbl.TabIndex = 3;
            chatbot_exitLbl.Text = "X";
            chatbot_exitLbl.Click += chatbot_exitLbl_Click;
            // 
            // chatbot_helpLbl
            // 
            chatbot_helpLbl.AutoSize = true;
            chatbot_helpLbl.Location = new Point(10, 2);
            chatbot_helpLbl.Name = "chatbot_helpLbl";
            chatbot_helpLbl.Size = new Size(16, 20);
            chatbot_helpLbl.TabIndex = 2;
            chatbot_helpLbl.Text = "?";
            chatbot_helpLbl.Click += chatbot_helpLbl_Click;
            // 
            // chatbot_replyPnl
            // 
            chatbot_replyPnl.BackColor = Color.White;
            chatbot_replyPnl.BorderStyle = BorderStyle.Fixed3D;
            chatbot_replyPnl.Controls.Add(chatbot_replyText);
            chatbot_replyPnl.Controls.Add(chatbot_replyPic);
            chatbot_replyPnl.Controls.Add(label4);
            chatbot_replyPnl.Location = new Point(12, 83);
            chatbot_replyPnl.Name = "chatbot_replyPnl";
            chatbot_replyPnl.Size = new Size(317, 95);
            chatbot_replyPnl.TabIndex = 34;
            // 
            // chatbot_replyText
            // 
            chatbot_replyText.Location = new Point(36, 5);
            chatbot_replyText.Multiline = true;
            chatbot_replyText.Name = "chatbot_replyText";
            chatbot_replyText.Size = new Size(274, 83);
            chatbot_replyText.TabIndex = 31;
            // 
            // chatbot_replyPic
            // 
            chatbot_replyPic.Image = (Image)resources.GetObject("chatbot_replyPic.Image");
            chatbot_replyPic.Location = new Point(3, 39);
            chatbot_replyPic.Name = "chatbot_replyPic";
            chatbot_replyPic.Size = new Size(27, 25);
            chatbot_replyPic.SizeMode = PictureBoxSizeMode.StretchImage;
            chatbot_replyPic.TabIndex = 29;
            chatbot_replyPic.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 5);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 3;
            label4.Visible = false;
            // 
            // chatbot_askBtn
            // 
            chatbot_askBtn.BackColor = Color.Gold;
            chatbot_askBtn.BackgroundImage = (Image)resources.GetObject("chatbot_askBtn.BackgroundImage");
            chatbot_askBtn.BackgroundImageLayout = ImageLayout.Stretch;
            chatbot_askBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chatbot_askBtn.ForeColor = Color.Black;
            chatbot_askBtn.Location = new Point(292, 50);
            chatbot_askBtn.Name = "chatbot_askBtn";
            chatbot_askBtn.Size = new Size(37, 27);
            chatbot_askBtn.TabIndex = 33;
            chatbot_askBtn.UseVisualStyleBackColor = false;
            chatbot_askBtn.Click += chatbot_askBtn_Click;
            // 
            // chatbot_questionTextBox
            // 
            chatbot_questionTextBox.Location = new Point(12, 50);
            chatbot_questionTextBox.Name = "chatbot_questionTextBox";
            chatbot_questionTextBox.Size = new Size(317, 27);
            chatbot_questionTextBox.TabIndex = 4;
            // 
            // chatbot_greetLbl
            // 
            chatbot_greetLbl.AutoSize = true;
            chatbot_greetLbl.Location = new Point(8, 27);
            chatbot_greetLbl.Name = "chatbot_greetLbl";
            chatbot_greetLbl.Size = new Size(323, 20);
            chatbot_greetLbl.TabIndex = 2;
            chatbot_greetLbl.Text = "I'm Hooty, your digital advisor! How can I help?";
            // 
            // chatbot_owlPic
            // 
            chatbot_owlPic.BackColor = Color.Transparent;
            chatbot_owlPic.Image = (Image)resources.GetObject("chatbot_owlPic.Image");
            chatbot_owlPic.Location = new Point(441, 637);
            chatbot_owlPic.Name = "chatbot_owlPic";
            chatbot_owlPic.Size = new Size(68, 62);
            chatbot_owlPic.SizeMode = PictureBoxSizeMode.StretchImage;
            chatbot_owlPic.TabIndex = 36;
            chatbot_owlPic.TabStop = false;
            chatbot_owlPic.Click += chatbot_owlPic_Click;
            // 
            // charges_helpBtn
            // 
            charges_helpBtn.BackColor = Color.Gold;
            charges_helpBtn.Font = new Font("Segoe UI", 9F);
            charges_helpBtn.ForeColor = Color.Black;
            charges_helpBtn.Location = new Point(44, 633);
            charges_helpBtn.Name = "charges_helpBtn";
            charges_helpBtn.Size = new Size(45, 37);
            charges_helpBtn.TabIndex = 27;
            charges_helpBtn.Text = "?";
            charges_helpBtn.UseVisualStyleBackColor = false;
            charges_helpBtn.Click += charges_helpBtn_Click;
            // 
            // charges_backBtn
            // 
            charges_backBtn.BackColor = Color.Gold;
            charges_backBtn.BackgroundImage = (Image)resources.GetObject("charges_backBtn.BackgroundImage");
            charges_backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            charges_backBtn.ForeColor = Color.FromArgb(64, 64, 64);
            charges_backBtn.Location = new Point(464, 15);
            charges_backBtn.Name = "charges_backBtn";
            charges_backBtn.Size = new Size(45, 37);
            charges_backBtn.TabIndex = 28;
            charges_backBtn.UseVisualStyleBackColor = false;
            charges_backBtn.Click += charges_backBtn_Click;
            // 
            // profile_editModeLbl
            // 
            profile_editModeLbl.AutoSize = true;
            profile_editModeLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            profile_editModeLbl.ForeColor = Color.Red;
            profile_editModeLbl.Location = new Point(233, 27);
            profile_editModeLbl.Name = "profile_editModeLbl";
            profile_editModeLbl.Size = new Size(175, 28);
            profile_editModeLbl.TabIndex = 26;
            profile_editModeLbl.Text = "*EDIT MODE = ON";
            profile_editModeLbl.Visible = false;
            // 
            // profile_namePicPnl
            // 
            profile_namePicPnl.BackColor = Color.White;
            profile_namePicPnl.BorderStyle = BorderStyle.FixedSingle;
            profile_namePicPnl.Controls.Add(label1);
            profile_namePicPnl.Controls.Add(profile_editPicLink);
            profile_namePicPnl.Controls.Add(profile_majorLbl);
            profile_namePicPnl.Controls.Add(profile_standingLbl);
            profile_namePicPnl.Controls.Add(profile_nameLbl);
            profile_namePicPnl.Controls.Add(profile_imgPic);
            profile_namePicPnl.Location = new Point(44, 67);
            profile_namePicPnl.Name = "profile_namePicPnl";
            profile_namePicPnl.Size = new Size(422, 138);
            profile_namePicPnl.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(202, 84);
            label1.Name = "label1";
            label1.Size = new Size(203, 28);
            label1.TabIndex = 6;
            label1.Text = "samaTudent@ksu.edu";
            // 
            // profile_editPicLink
            // 
            profile_editPicLink.AutoSize = true;
            profile_editPicLink.Font = new Font("Segoe UI", 7.8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            profile_editPicLink.Location = new Point(24, 111);
            profile_editPicLink.Name = "profile_editPicLink";
            profile_editPicLink.Size = new Size(73, 17);
            profile_editPicLink.TabIndex = 5;
            profile_editPicLink.Text = "Edit Picture";
            profile_editPicLink.Click += profile_editPicLink_Click;
            // 
            // profile_majorLbl
            // 
            profile_majorLbl.AutoSize = true;
            profile_majorLbl.Font = new Font("Segoe UI", 12F);
            profile_majorLbl.Location = new Point(202, 60);
            profile_majorLbl.Name = "profile_majorLbl";
            profile_majorLbl.Size = new Size(170, 28);
            profile_majorLbl.TabIndex = 4;
            profile_majorLbl.Text = "Computer Science";
            // 
            // profile_standingLbl
            // 
            profile_standingLbl.AutoSize = true;
            profile_standingLbl.Font = new Font("Segoe UI", 12F);
            profile_standingLbl.Location = new Point(202, 35);
            profile_standingLbl.Name = "profile_standingLbl";
            profile_standingLbl.Size = new Size(116, 28);
            profile_standingLbl.TabIndex = 3;
            profile_standingLbl.Text = "Sophomore";
            // 
            // profile_nameLbl
            // 
            profile_nameLbl.AutoSize = true;
            profile_nameLbl.Font = new Font("Segoe UI", 12F);
            profile_nameLbl.Location = new Point(202, 12);
            profile_nameLbl.Name = "profile_nameLbl";
            profile_nameLbl.Size = new Size(146, 28);
            profile_nameLbl.TabIndex = 2;
            profile_nameLbl.Text = "Sama S. Tudent";
            profile_nameLbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // profile_imgPic
            // 
            profile_imgPic.BorderStyle = BorderStyle.FixedSingle;
            profile_imgPic.Image = (Image)resources.GetObject("profile_imgPic.Image");
            profile_imgPic.Location = new Point(26, 8);
            profile_imgPic.Name = "profile_imgPic";
            profile_imgPic.Size = new Size(129, 100);
            profile_imgPic.SizeMode = PictureBoxSizeMode.StretchImage;
            profile_imgPic.TabIndex = 0;
            profile_imgPic.TabStop = false;
            // 
            // profile_textPnl
            // 
            profile_textPnl.BackColor = Color.White;
            profile_textPnl.BorderStyle = BorderStyle.FixedSingle;
            profile_textPnl.Controls.Add(profile_saveBtn);
            profile_textPnl.Controls.Add(profile_editProfileBtn);
            profile_textPnl.Controls.Add(profile_bioLbl);
            profile_textPnl.Controls.Add(profile_bioText);
            profile_textPnl.Location = new Point(44, 332);
            profile_textPnl.Name = "profile_textPnl";
            profile_textPnl.Size = new Size(422, 295);
            profile_textPnl.TabIndex = 24;
            // 
            // profile_saveBtn
            // 
            profile_saveBtn.BackColor = Color.Gold;
            profile_saveBtn.Location = new Point(294, 259);
            profile_saveBtn.Name = "profile_saveBtn";
            profile_saveBtn.Size = new Size(113, 29);
            profile_saveBtn.TabIndex = 27;
            profile_saveBtn.Text = "Save Profile";
            profile_saveBtn.UseVisualStyleBackColor = false;
            profile_saveBtn.Click += profile_saveBtn_Click;
            // 
            // profile_editProfileBtn
            // 
            profile_editProfileBtn.BackColor = Color.Gold;
            profile_editProfileBtn.Location = new Point(12, 259);
            profile_editProfileBtn.Name = "profile_editProfileBtn";
            profile_editProfileBtn.Size = new Size(113, 29);
            profile_editProfileBtn.TabIndex = 26;
            profile_editProfileBtn.Text = "Edit Profile";
            profile_editProfileBtn.UseVisualStyleBackColor = false;
            profile_editProfileBtn.Click += profile_editProfileBtn_Click;
            // 
            // profile_bioLbl
            // 
            profile_bioLbl.AutoSize = true;
            profile_bioLbl.Location = new Point(14, 0);
            profile_bioLbl.Name = "profile_bioLbl";
            profile_bioLbl.Size = new Size(34, 20);
            profile_bioLbl.TabIndex = 2;
            profile_bioLbl.Text = "Bio:";
            // 
            // profile_bioText
            // 
            profile_bioText.BackColor = Color.WhiteSmoke;
            profile_bioText.Location = new Point(12, 23);
            profile_bioText.Multiline = true;
            profile_bioText.Name = "profile_bioText";
            profile_bioText.ReadOnly = true;
            profile_bioText.Size = new Size(395, 230);
            profile_bioText.TabIndex = 1;
            // 
            // profile_titlePnl
            // 
            profile_titlePnl.BackColor = Color.White;
            profile_titlePnl.BorderStyle = BorderStyle.FixedSingle;
            profile_titlePnl.Controls.Add(profile_titleIcon);
            profile_titlePnl.Controls.Add(profile_titleLbl);
            profile_titlePnl.Location = new Point(44, 27);
            profile_titlePnl.Name = "profile_titlePnl";
            profile_titlePnl.Size = new Size(188, 40);
            profile_titlePnl.TabIndex = 23;
            // 
            // profile_titleIcon
            // 
            profile_titleIcon.BorderStyle = BorderStyle.FixedSingle;
            profile_titleIcon.Image = (Image)resources.GetObject("profile_titleIcon.Image");
            profile_titleIcon.Location = new Point(3, 3);
            profile_titleIcon.Name = "profile_titleIcon";
            profile_titleIcon.Size = new Size(43, 32);
            profile_titleIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            profile_titleIcon.TabIndex = 23;
            profile_titleIcon.TabStop = false;
            // 
            // profile_titleLbl
            // 
            profile_titleLbl.AutoSize = true;
            profile_titleLbl.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profile_titleLbl.ForeColor = Color.Gold;
            profile_titleLbl.Location = new Point(52, 6);
            profile_titleLbl.Name = "profile_titleLbl";
            profile_titleLbl.Size = new Size(130, 27);
            profile_titleLbl.TabIndex = 0;
            profile_titleLbl.Text = "myProfile";
            // 
            // profile_miscPnl
            // 
            profile_miscPnl.BackColor = Color.White;
            profile_miscPnl.BorderStyle = BorderStyle.FixedSingle;
            profile_miscPnl.Controls.Add(profile_quoteLbl);
            profile_miscPnl.Controls.Add(profile_interestsLbl);
            profile_miscPnl.Controls.Add(profile_quoteText);
            profile_miscPnl.Controls.Add(profile_websiteLbl);
            profile_miscPnl.Controls.Add(profile_interestsText);
            profile_miscPnl.Controls.Add(profile_websiteText);
            profile_miscPnl.Location = new Point(44, 211);
            profile_miscPnl.Name = "profile_miscPnl";
            profile_miscPnl.Size = new Size(422, 115);
            profile_miscPnl.TabIndex = 0;
            // 
            // profile_quoteLbl
            // 
            profile_quoteLbl.AutoSize = true;
            profile_quoteLbl.Location = new Point(26, 88);
            profile_quoteLbl.Name = "profile_quoteLbl";
            profile_quoteLbl.Size = new Size(53, 20);
            profile_quoteLbl.TabIndex = 4;
            profile_quoteLbl.Text = "Quote:";
            // 
            // profile_interestsLbl
            // 
            profile_interestsLbl.AutoSize = true;
            profile_interestsLbl.Location = new Point(12, 55);
            profile_interestsLbl.Name = "profile_interestsLbl";
            profile_interestsLbl.Size = new Size(67, 20);
            profile_interestsLbl.TabIndex = 3;
            profile_interestsLbl.Text = "Interests:";
            // 
            // profile_quoteText
            // 
            profile_quoteText.BackColor = Color.WhiteSmoke;
            profile_quoteText.Location = new Point(92, 81);
            profile_quoteText.Name = "profile_quoteText";
            profile_quoteText.ReadOnly = true;
            profile_quoteText.Size = new Size(315, 27);
            profile_quoteText.TabIndex = 0;
            // 
            // profile_websiteLbl
            // 
            profile_websiteLbl.AutoSize = true;
            profile_websiteLbl.Location = new Point(14, 22);
            profile_websiteLbl.Name = "profile_websiteLbl";
            profile_websiteLbl.Size = new Size(65, 20);
            profile_websiteLbl.TabIndex = 2;
            profile_websiteLbl.Text = "Website:";
            // 
            // profile_interestsText
            // 
            profile_interestsText.BackColor = Color.WhiteSmoke;
            profile_interestsText.Location = new Point(94, 48);
            profile_interestsText.Name = "profile_interestsText";
            profile_interestsText.ReadOnly = true;
            profile_interestsText.Size = new Size(315, 27);
            profile_interestsText.TabIndex = 1;
            // 
            // profile_websiteText
            // 
            profile_websiteText.BackColor = Color.WhiteSmoke;
            profile_websiteText.Location = new Point(94, 15);
            profile_websiteText.Name = "profile_websiteText";
            profile_websiteText.ReadOnly = true;
            profile_websiteText.Size = new Size(315, 27);
            profile_websiteText.TabIndex = 0;
            // 
            // myProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 699);
            Controls.Add(profile_mainPnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(539, 746);
            MinimumSize = new Size(539, 746);
            Name = "myProfileForm";
            Text = "[ myProfile ]";
            profile_mainPnl.ResumeLayout(false);
            profile_mainPnl.PerformLayout();
            chatbot_mainPnl.ResumeLayout(false);
            chatbot_mainPnl.PerformLayout();
            chatbot_topPnl.ResumeLayout(false);
            chatbot_topPnl.PerformLayout();
            chatbot_replyPnl.ResumeLayout(false);
            chatbot_replyPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_replyPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatbot_owlPic).EndInit();
            profile_namePicPnl.ResumeLayout(false);
            profile_namePicPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profile_imgPic).EndInit();
            profile_textPnl.ResumeLayout(false);
            profile_textPnl.PerformLayout();
            profile_titlePnl.ResumeLayout(false);
            profile_titlePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profile_titleIcon).EndInit();
            profile_miscPnl.ResumeLayout(false);
            profile_miscPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel profile_mainPnl;
        private Panel profile_miscPnl;
        private Panel profile_titlePnl;
        private PictureBox profile_titleIcon;
        private Label profile_titleLbl;
        private Panel profile_textPnl;
        private Label profile_bioLbl;
        private TextBox profile_bioText;
        private TextBox profile_quoteText;
        private Label profile_interestsLbl;
        private Label profile_websiteLbl;
        private TextBox profile_interestsText;
        private TextBox profile_websiteText;
        private Label profile_quoteLbl;
        private Panel profile_namePicPnl;
        private PictureBox profile_imgPic;
        private Label profile_majorLbl;
        private Label profile_standingLbl;
        private Label profile_nameLbl;
        private Button profile_saveBtn;
        private Button profile_editProfileBtn;
        private Label profile_editModeLbl;
        private Button charges_helpBtn;
        private Button charges_backBtn;
        private PictureBox chatbot_owlPic;
        private Label profile_editPicLink;
        private Label label1;
        private Panel chatbot_mainPnl;
        private Panel chatbot_topPnl;
        private Label chatbot_exitLbl;
        private Label chatbot_helpLbl;
        private Panel chatbot_replyPnl;
        private TextBox chatbot_replyText;
        private PictureBox chatbot_replyPic;
        private Label label4;
        private Button chatbot_askBtn;
        private TextBox chatbot_questionTextBox;
        private Label chatbot_greetLbl;
    }
}
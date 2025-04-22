namespace myKSU_v3
{
    partial class myHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myHomeForm));
            home_helpBtn = new Button();
            home_exitBtn = new Button();
            home_mainPnl = new Panel();
            chatbot_owlPic = new PictureBox();
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
            featherPicBox = new PictureBox();
            home_myRegistrationPnl = new Panel();
            home_myRegistrationBtn = new Button();
            home_myRegistrationIco = new PictureBox();
            home_myCoursesPnl = new Panel();
            home_myCoursesBtn = new Button();
            home_myCoursesIco = new PictureBox();
            home_mySchedulePnl = new Panel();
            home_mySheduleBtn = new Button();
            home_myScheduleIco = new PictureBox();
            home_myPaymentsPnl = new Panel();
            home_myPaymentsBtn = new Button();
            home_myPaymentsIco = new PictureBox();
            home_myProfilePnl = new Panel();
            home_myProfileBtn = new Button();
            home_myProfileIco = new PictureBox();
            home_logoPic = new PictureBox();
            home_mainPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_owlPic).BeginInit();
            chatbot_mainPnl.SuspendLayout();
            chatbot_topPnl.SuspendLayout();
            chatbot_replyPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_replyPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)featherPicBox).BeginInit();
            home_myRegistrationPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)home_myRegistrationIco).BeginInit();
            home_myCoursesPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)home_myCoursesIco).BeginInit();
            home_mySchedulePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)home_myScheduleIco).BeginInit();
            home_myPaymentsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)home_myPaymentsIco).BeginInit();
            home_myProfilePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)home_myProfileIco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)home_logoPic).BeginInit();
            SuspendLayout();
            // 
            // home_helpBtn
            // 
            home_helpBtn.BackColor = Color.Gold;
            home_helpBtn.ForeColor = Color.Black;
            home_helpBtn.Location = new Point(68, 650);
            home_helpBtn.Name = "home_helpBtn";
            home_helpBtn.Size = new Size(45, 37);
            home_helpBtn.TabIndex = 12;
            home_helpBtn.Text = "?";
            home_helpBtn.UseVisualStyleBackColor = false;
            home_helpBtn.Click += home_helpBtn_Click;
            // 
            // home_exitBtn
            // 
            home_exitBtn.BackColor = Color.Gold;
            home_exitBtn.ForeColor = Color.Black;
            home_exitBtn.Location = new Point(464, 12);
            home_exitBtn.Name = "home_exitBtn";
            home_exitBtn.Size = new Size(45, 37);
            home_exitBtn.TabIndex = 13;
            home_exitBtn.Text = "X";
            home_exitBtn.UseVisualStyleBackColor = false;
            home_exitBtn.Click += home_exitBtn_Click;
            // 
            // home_mainPnl
            // 
            home_mainPnl.BackgroundImage = (Image)resources.GetObject("home_mainPnl.BackgroundImage");
            home_mainPnl.Controls.Add(chatbot_owlPic);
            home_mainPnl.Controls.Add(chatbot_mainPnl);
            home_mainPnl.Controls.Add(featherPicBox);
            home_mainPnl.Controls.Add(home_myRegistrationPnl);
            home_mainPnl.Controls.Add(home_helpBtn);
            home_mainPnl.Controls.Add(home_exitBtn);
            home_mainPnl.Controls.Add(home_myCoursesPnl);
            home_mainPnl.Controls.Add(home_mySchedulePnl);
            home_mainPnl.Controls.Add(home_myPaymentsPnl);
            home_mainPnl.Controls.Add(home_myProfilePnl);
            home_mainPnl.Controls.Add(home_logoPic);
            home_mainPnl.Dock = DockStyle.Fill;
            home_mainPnl.Location = new Point(0, 0);
            home_mainPnl.Name = "home_mainPnl";
            home_mainPnl.Size = new Size(521, 699);
            home_mainPnl.TabIndex = 15;
            // 
            // chatbot_owlPic
            // 
            chatbot_owlPic.BackColor = Color.Transparent;
            chatbot_owlPic.Image = (Image)resources.GetObject("chatbot_owlPic.Image");
            chatbot_owlPic.Location = new Point(441, 637);
            chatbot_owlPic.Name = "chatbot_owlPic";
            chatbot_owlPic.Size = new Size(68, 62);
            chatbot_owlPic.SizeMode = PictureBoxSizeMode.StretchImage;
            chatbot_owlPic.TabIndex = 37;
            chatbot_owlPic.TabStop = false;
            chatbot_owlPic.Click += chatbot_owlPic_Click;
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
            chatbot_mainPnl.TabIndex = 29;
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
            // featherPicBox
            // 
            featherPicBox.Image = (Image)resources.GetObject("featherPicBox.Image");
            featherPicBox.Location = new Point(397, 118);
            featherPicBox.Name = "featherPicBox";
            featherPicBox.Size = new Size(27, 25);
            featherPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            featherPicBox.TabIndex = 28;
            featherPicBox.TabStop = false;
            // 
            // home_myRegistrationPnl
            // 
            home_myRegistrationPnl.BorderStyle = BorderStyle.FixedSingle;
            home_myRegistrationPnl.Controls.Add(home_myRegistrationBtn);
            home_myRegistrationPnl.Controls.Add(home_myRegistrationIco);
            home_myRegistrationPnl.Location = new Point(274, 154);
            home_myRegistrationPnl.Name = "home_myRegistrationPnl";
            home_myRegistrationPnl.Size = new Size(182, 160);
            home_myRegistrationPnl.TabIndex = 24;
            // 
            // home_myRegistrationBtn
            // 
            home_myRegistrationBtn.BackColor = Color.Gold;
            home_myRegistrationBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home_myRegistrationBtn.Location = new Point(3, 111);
            home_myRegistrationBtn.Name = "home_myRegistrationBtn";
            home_myRegistrationBtn.Size = new Size(174, 44);
            home_myRegistrationBtn.TabIndex = 3;
            home_myRegistrationBtn.Text = "myRegistration";
            home_myRegistrationBtn.UseVisualStyleBackColor = false;
            home_myRegistrationBtn.Click += home_myRegistrationBtn_Click;
            // 
            // home_myRegistrationIco
            // 
            home_myRegistrationIco.Image = (Image)resources.GetObject("home_myRegistrationIco.Image");
            home_myRegistrationIco.Location = new Point(17, 17);
            home_myRegistrationIco.Name = "home_myRegistrationIco";
            home_myRegistrationIco.Size = new Size(138, 87);
            home_myRegistrationIco.SizeMode = PictureBoxSizeMode.StretchImage;
            home_myRegistrationIco.TabIndex = 2;
            home_myRegistrationIco.TabStop = false;
            // 
            // home_myCoursesPnl
            // 
            home_myCoursesPnl.BorderStyle = BorderStyle.FixedSingle;
            home_myCoursesPnl.Controls.Add(home_myCoursesBtn);
            home_myCoursesPnl.Controls.Add(home_myCoursesIco);
            home_myCoursesPnl.Location = new Point(68, 154);
            home_myCoursesPnl.Name = "home_myCoursesPnl";
            home_myCoursesPnl.Size = new Size(182, 160);
            home_myCoursesPnl.TabIndex = 23;
            // 
            // home_myCoursesBtn
            // 
            home_myCoursesBtn.BackColor = Color.Gold;
            home_myCoursesBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home_myCoursesBtn.Location = new Point(3, 113);
            home_myCoursesBtn.Name = "home_myCoursesBtn";
            home_myCoursesBtn.Size = new Size(174, 44);
            home_myCoursesBtn.TabIndex = 1;
            home_myCoursesBtn.Text = "myCourses";
            home_myCoursesBtn.UseVisualStyleBackColor = false;
            home_myCoursesBtn.Click += home_myCoursesBtn_Click;
            // 
            // home_myCoursesIco
            // 
            home_myCoursesIco.Image = (Image)resources.GetObject("home_myCoursesIco.Image");
            home_myCoursesIco.Location = new Point(17, 17);
            home_myCoursesIco.Name = "home_myCoursesIco";
            home_myCoursesIco.Size = new Size(147, 87);
            home_myCoursesIco.SizeMode = PictureBoxSizeMode.StretchImage;
            home_myCoursesIco.TabIndex = 0;
            home_myCoursesIco.TabStop = false;
            // 
            // home_mySchedulePnl
            // 
            home_mySchedulePnl.BorderStyle = BorderStyle.FixedSingle;
            home_mySchedulePnl.Controls.Add(home_mySheduleBtn);
            home_mySchedulePnl.Controls.Add(home_myScheduleIco);
            home_mySchedulePnl.Location = new Point(68, 321);
            home_mySchedulePnl.Name = "home_mySchedulePnl";
            home_mySchedulePnl.Size = new Size(182, 160);
            home_mySchedulePnl.TabIndex = 22;
            // 
            // home_mySheduleBtn
            // 
            home_mySheduleBtn.BackColor = Color.Gold;
            home_mySheduleBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home_mySheduleBtn.Location = new Point(3, 113);
            home_mySheduleBtn.Name = "home_mySheduleBtn";
            home_mySheduleBtn.Size = new Size(174, 44);
            home_mySheduleBtn.TabIndex = 2;
            home_mySheduleBtn.Text = "mySchedule";
            home_mySheduleBtn.UseVisualStyleBackColor = false;
            home_mySheduleBtn.Click += home_mySheduleBtn_Click;
            // 
            // home_myScheduleIco
            // 
            home_myScheduleIco.Image = (Image)resources.GetObject("home_myScheduleIco.Image");
            home_myScheduleIco.Location = new Point(17, 13);
            home_myScheduleIco.Name = "home_myScheduleIco";
            home_myScheduleIco.Size = new Size(147, 94);
            home_myScheduleIco.SizeMode = PictureBoxSizeMode.StretchImage;
            home_myScheduleIco.TabIndex = 1;
            home_myScheduleIco.TabStop = false;
            // 
            // home_myPaymentsPnl
            // 
            home_myPaymentsPnl.BorderStyle = BorderStyle.FixedSingle;
            home_myPaymentsPnl.Controls.Add(home_myPaymentsBtn);
            home_myPaymentsPnl.Controls.Add(home_myPaymentsIco);
            home_myPaymentsPnl.Location = new Point(274, 321);
            home_myPaymentsPnl.Name = "home_myPaymentsPnl";
            home_myPaymentsPnl.Size = new Size(182, 160);
            home_myPaymentsPnl.TabIndex = 21;
            // 
            // home_myPaymentsBtn
            // 
            home_myPaymentsBtn.BackColor = Color.Gold;
            home_myPaymentsBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home_myPaymentsBtn.Location = new Point(3, 111);
            home_myPaymentsBtn.Name = "home_myPaymentsBtn";
            home_myPaymentsBtn.Size = new Size(174, 44);
            home_myPaymentsBtn.TabIndex = 25;
            home_myPaymentsBtn.Text = "myCharges";
            home_myPaymentsBtn.UseVisualStyleBackColor = false;
            home_myPaymentsBtn.Click += home_myPaymentsBtn_Click;
            // 
            // home_myPaymentsIco
            // 
            home_myPaymentsIco.Image = (Image)resources.GetObject("home_myPaymentsIco.Image");
            home_myPaymentsIco.Location = new Point(17, 14);
            home_myPaymentsIco.Name = "home_myPaymentsIco";
            home_myPaymentsIco.Size = new Size(147, 87);
            home_myPaymentsIco.SizeMode = PictureBoxSizeMode.StretchImage;
            home_myPaymentsIco.TabIndex = 24;
            home_myPaymentsIco.TabStop = false;
            // 
            // home_myProfilePnl
            // 
            home_myProfilePnl.BorderStyle = BorderStyle.FixedSingle;
            home_myProfilePnl.Controls.Add(home_myProfileBtn);
            home_myProfilePnl.Controls.Add(home_myProfileIco);
            home_myProfilePnl.Location = new Point(68, 487);
            home_myProfilePnl.Name = "home_myProfilePnl";
            home_myProfilePnl.Size = new Size(182, 160);
            home_myProfilePnl.TabIndex = 20;
            // 
            // home_myProfileBtn
            // 
            home_myProfileBtn.BackColor = Color.Gold;
            home_myProfileBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            home_myProfileBtn.Location = new Point(3, 111);
            home_myProfileBtn.Name = "home_myProfileBtn";
            home_myProfileBtn.Size = new Size(174, 44);
            home_myProfileBtn.TabIndex = 25;
            home_myProfileBtn.Text = "myProfile";
            home_myProfileBtn.UseVisualStyleBackColor = false;
            home_myProfileBtn.Click += home_myProfileBtn_Click;
            // 
            // home_myProfileIco
            // 
            home_myProfileIco.Image = (Image)resources.GetObject("home_myProfileIco.Image");
            home_myProfileIco.Location = new Point(27, 14);
            home_myProfileIco.Name = "home_myProfileIco";
            home_myProfileIco.Size = new Size(119, 87);
            home_myProfileIco.SizeMode = PictureBoxSizeMode.StretchImage;
            home_myProfileIco.TabIndex = 24;
            home_myProfileIco.TabStop = false;
            // 
            // home_logoPic
            // 
            home_logoPic.Anchor = AnchorStyles.None;
            home_logoPic.BorderStyle = BorderStyle.FixedSingle;
            home_logoPic.Image = (Image)resources.GetObject("home_logoPic.Image");
            home_logoPic.Location = new Point(68, 12);
            home_logoPic.Name = "home_logoPic";
            home_logoPic.Size = new Size(388, 136);
            home_logoPic.SizeMode = PictureBoxSizeMode.StretchImage;
            home_logoPic.TabIndex = 16;
            home_logoPic.TabStop = false;
            // 
            // myHomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(521, 699);
            Controls.Add(home_mainPnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(539, 746);
            MinimumSize = new Size(539, 746);
            Name = "myHomeForm";
            Text = "[ myHome ]";
            home_mainPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chatbot_owlPic).EndInit();
            chatbot_mainPnl.ResumeLayout(false);
            chatbot_mainPnl.PerformLayout();
            chatbot_topPnl.ResumeLayout(false);
            chatbot_topPnl.PerformLayout();
            chatbot_replyPnl.ResumeLayout(false);
            chatbot_replyPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_replyPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)featherPicBox).EndInit();
            home_myRegistrationPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)home_myRegistrationIco).EndInit();
            home_myCoursesPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)home_myCoursesIco).EndInit();
            home_mySchedulePnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)home_myScheduleIco).EndInit();
            home_myPaymentsPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)home_myPaymentsIco).EndInit();
            home_myProfilePnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)home_myProfileIco).EndInit();
            ((System.ComponentModel.ISupportInitialize)home_logoPic).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button home_helpBtn;
        private Button home_exitBtn;
        private Panel home_myRegistrationPnl;
        private Panel home_myCoursesPnl;
        private Panel home_mySchedulePnl;
        private Panel home_myPaymentsPnl;
        private Panel home_myProfilePnl;
        private Panel home_mainPnl;
        private PictureBox home_logoPic;
        private PictureBox home_myCoursesIco;
        private PictureBox home_myScheduleIco;
        private PictureBox home_myRegistrationIco;
        private PictureBox home_myPaymentsIco;
        private PictureBox home_myProfileIco;
        private Button home_myCoursesBtn;
        private Button home_mySheduleBtn;
        private Button home_myRegistrationBtn;
        private Button home_myPaymentsBtn;
        private Button home_myProfileBtn;
        private PictureBox featherPicBox;
        private Panel chatbot_mainPnl;
        private TextBox chatbot_questionTextBox;
        private Label label4;
        private Label chatbot_greetLbl;
        private Panel chatbot_replyPnl;
        private Button chatbot_askBtn;
        private Panel chatbot_topPnl;
        private Label chatbot_exitLbl;
        private Label chatbot_helpLbl;
        private PictureBox chatbot_replyPic;
        private PictureBox chatbot_owlPic;
        private TextBox chatbot_replyText;
    }
}
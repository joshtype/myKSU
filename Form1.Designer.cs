namespace myKSU
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            loginTab = new TabPage();
            loginLogo = new PictureBox();
            button7 = new Button();
            loginHelpBtn = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            myHomeTab = new TabPage();
            ksuLink = new Label();
            uitsLink = new Label();
            myHomeLogoutBtn = new Button();
            myHomeHelpBtn = new Button();
            myProfileBtn = new Button();
            myPaymentsBtn = new Button();
            myAdvisorBtn = new Button();
            myScheduleBtn = new Button();
            myRegistrationBtn = new Button();
            myCoursesBtn = new Button();
            myHomeLogo = new PictureBox();
            myCoursesTab = new TabPage();
            myCoursesHelpBtn = new Button();
            myRegistrationTab = new TabPage();
            myRegisHelpBtn = new Button();
            myScheduleTab = new TabPage();
            myScheduleHelpBtn = new Button();
            myAdvisorTab = new TabPage();
            myAdvisorHelpBtn = new Button();
            myPaymentsTab = new TabPage();
            myPaymentsHelpBtn = new Button();
            myProfileTab = new TabPage();
            myProfileHelpBtn = new Button();
            tabControl1.SuspendLayout();
            loginTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loginLogo).BeginInit();
            myHomeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myHomeLogo).BeginInit();
            myCoursesTab.SuspendLayout();
            myRegistrationTab.SuspendLayout();
            myScheduleTab.SuspendLayout();
            myAdvisorTab.SuspendLayout();
            myPaymentsTab.SuspendLayout();
            myProfileTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(loginTab);
            tabControl1.Controls.Add(myHomeTab);
            tabControl1.Controls.Add(myCoursesTab);
            tabControl1.Controls.Add(myRegistrationTab);
            tabControl1.Controls.Add(myScheduleTab);
            tabControl1.Controls.Add(myAdvisorTab);
            tabControl1.Controls.Add(myPaymentsTab);
            tabControl1.Controls.Add(myProfileTab);
            tabControl1.Location = new Point(-4, -9);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(630, 826);
            tabControl1.TabIndex = 0;
            // 
            // loginTab
            // 
            loginTab.BackColor = Color.White;
            loginTab.Controls.Add(loginLogo);
            loginTab.Controls.Add(button7);
            loginTab.Controls.Add(loginHelpBtn);
            loginTab.Controls.Add(textBox3);
            loginTab.Controls.Add(label3);
            loginTab.Controls.Add(label2);
            loginTab.Controls.Add(label1);
            loginTab.Controls.Add(textBox2);
            loginTab.Controls.Add(textBox1);
            loginTab.Location = new Point(4, 29);
            loginTab.Name = "loginTab";
            loginTab.Padding = new Padding(3);
            loginTab.Size = new Size(622, 793);
            loginTab.TabIndex = 0;
            loginTab.Text = "login";
            // 
            // loginLogo
            // 
            loginLogo.Image = (Image)resources.GetObject("loginLogo.Image");
            loginLogo.Location = new Point(88, 6);
            loginLogo.Name = "loginLogo";
            loginLogo.Size = new Size(449, 246);
            loginLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            loginLogo.TabIndex = 8;
            loginLogo.TabStop = false;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(255, 255, 128);
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(255, 550);
            button7.Name = "button7";
            button7.Size = new Size(144, 48);
            button7.TabIndex = 7;
            button7.Text = "Authenticate";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // loginHelpBtn
            // 
            loginHelpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginHelpBtn.Location = new Point(570, 6);
            loginHelpBtn.Name = "loginHelpBtn";
            loginHelpBtn.Size = new Size(44, 37);
            loginHelpBtn.TabIndex = 6;
            loginHelpBtn.Text = "?";
            loginHelpBtn.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(255, 490);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(233, 38);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(146, 500);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 4;
            label3.Text = "KSU ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 440);
            label2.Name = "label2";
            label2.Size = new Size(139, 28);
            label2.TabIndex = 3;
            label2.Text = "KSU Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 380);
            label1.Name = "label1";
            label1.Size = new Size(145, 28);
            label1.TabIndex = 2;
            label1.Text = "KSU Username:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(255, 430);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 38);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(255, 370);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 38);
            textBox1.TabIndex = 0;
            // 
            // myHomeTab
            // 
            myHomeTab.BackColor = Color.White;
            myHomeTab.Controls.Add(ksuLink);
            myHomeTab.Controls.Add(uitsLink);
            myHomeTab.Controls.Add(myHomeLogoutBtn);
            myHomeTab.Controls.Add(myHomeHelpBtn);
            myHomeTab.Controls.Add(myProfileBtn);
            myHomeTab.Controls.Add(myPaymentsBtn);
            myHomeTab.Controls.Add(myAdvisorBtn);
            myHomeTab.Controls.Add(myScheduleBtn);
            myHomeTab.Controls.Add(myRegistrationBtn);
            myHomeTab.Controls.Add(myCoursesBtn);
            myHomeTab.Controls.Add(myHomeLogo);
            myHomeTab.Location = new Point(4, 29);
            myHomeTab.Name = "myHomeTab";
            myHomeTab.Padding = new Padding(3);
            myHomeTab.Size = new Size(622, 793);
            myHomeTab.TabIndex = 1;
            myHomeTab.Text = "myHome";
            // 
            // ksuLink
            // 
            ksuLink.AutoSize = true;
            ksuLink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ksuLink.Location = new Point(192, 728);
            ksuLink.Name = "ksuLink";
            ksuLink.Size = new Size(239, 28);
            ksuLink.TabIndex = 10;
            ksuLink.Text = "Kennesaw State University";
            // 
            // uitsLink
            // 
            uitsLink.AutoSize = true;
            uitsLink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            uitsLink.Location = new Point(204, 756);
            uitsLink.Name = "uitsLink";
            uitsLink.Size = new Size(212, 28);
            uitsLink.TabIndex = 9;
            uitsLink.Text = "UITS Technical Support";
            // 
            // myHomeLogoutBtn
            // 
            myHomeLogoutBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myHomeLogoutBtn.Location = new Point(6, 6);
            myHomeLogoutBtn.Name = "myHomeLogoutBtn";
            myHomeLogoutBtn.Size = new Size(44, 37);
            myHomeLogoutBtn.TabIndex = 8;
            myHomeLogoutBtn.Text = "X";
            myHomeLogoutBtn.UseVisualStyleBackColor = true;
            // 
            // myHomeHelpBtn
            // 
            myHomeHelpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myHomeHelpBtn.Location = new Point(570, 6);
            myHomeHelpBtn.Name = "myHomeHelpBtn";
            myHomeHelpBtn.Size = new Size(44, 37);
            myHomeHelpBtn.TabIndex = 7;
            myHomeHelpBtn.Text = "?";
            myHomeHelpBtn.UseVisualStyleBackColor = true;
            // 
            // myProfileBtn
            // 
            myProfileBtn.BackColor = Color.FromArgb(255, 255, 128);
            myProfileBtn.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myProfileBtn.Location = new Point(88, 621);
            myProfileBtn.Name = "myProfileBtn";
            myProfileBtn.Size = new Size(449, 62);
            myProfileBtn.TabIndex = 6;
            myProfileBtn.Text = "myProfile";
            myProfileBtn.UseVisualStyleBackColor = false;
            // 
            // myPaymentsBtn
            // 
            myPaymentsBtn.BackColor = Color.FromArgb(255, 255, 128);
            myPaymentsBtn.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myPaymentsBtn.Location = new Point(88, 553);
            myPaymentsBtn.Name = "myPaymentsBtn";
            myPaymentsBtn.Size = new Size(449, 62);
            myPaymentsBtn.TabIndex = 5;
            myPaymentsBtn.Text = "myPayments";
            myPaymentsBtn.UseVisualStyleBackColor = false;
            // 
            // myAdvisorBtn
            // 
            myAdvisorBtn.BackColor = Color.FromArgb(255, 255, 128);
            myAdvisorBtn.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myAdvisorBtn.Location = new Point(88, 485);
            myAdvisorBtn.Name = "myAdvisorBtn";
            myAdvisorBtn.Size = new Size(449, 62);
            myAdvisorBtn.TabIndex = 4;
            myAdvisorBtn.Text = "myAdvisor";
            myAdvisorBtn.UseVisualStyleBackColor = false;
            // 
            // myScheduleBtn
            // 
            myScheduleBtn.BackColor = Color.FromArgb(255, 255, 128);
            myScheduleBtn.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myScheduleBtn.Location = new Point(88, 417);
            myScheduleBtn.Name = "myScheduleBtn";
            myScheduleBtn.Size = new Size(449, 62);
            myScheduleBtn.TabIndex = 3;
            myScheduleBtn.Text = "mySchedule";
            myScheduleBtn.UseVisualStyleBackColor = false;
            // 
            // myRegistrationBtn
            // 
            myRegistrationBtn.BackColor = Color.FromArgb(255, 255, 128);
            myRegistrationBtn.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myRegistrationBtn.Location = new Point(88, 349);
            myRegistrationBtn.Name = "myRegistrationBtn";
            myRegistrationBtn.Size = new Size(449, 62);
            myRegistrationBtn.TabIndex = 2;
            myRegistrationBtn.Text = "myRegistration";
            myRegistrationBtn.UseVisualStyleBackColor = false;
            // 
            // myCoursesBtn
            // 
            myCoursesBtn.BackColor = Color.FromArgb(255, 255, 128);
            myCoursesBtn.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myCoursesBtn.Location = new Point(88, 281);
            myCoursesBtn.Name = "myCoursesBtn";
            myCoursesBtn.Size = new Size(449, 62);
            myCoursesBtn.TabIndex = 1;
            myCoursesBtn.Text = "myCourses";
            myCoursesBtn.UseVisualStyleBackColor = false;
            // 
            // myHomeLogo
            // 
            myHomeLogo.Image = (Image)resources.GetObject("myHomeLogo.Image");
            myHomeLogo.Location = new Point(88, 6);
            myHomeLogo.Name = "myHomeLogo";
            myHomeLogo.Size = new Size(449, 246);
            myHomeLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            myHomeLogo.TabIndex = 0;
            myHomeLogo.TabStop = false;
            // 
            // myCoursesTab
            // 
            myCoursesTab.BackColor = Color.White;
            myCoursesTab.Controls.Add(myCoursesHelpBtn);
            myCoursesTab.Location = new Point(4, 29);
            myCoursesTab.Name = "myCoursesTab";
            myCoursesTab.Padding = new Padding(3);
            myCoursesTab.Size = new Size(622, 793);
            myCoursesTab.TabIndex = 2;
            myCoursesTab.Text = "myCourses";
            // 
            // myCoursesHelpBtn
            // 
            myCoursesHelpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myCoursesHelpBtn.Location = new Point(570, 6);
            myCoursesHelpBtn.Name = "myCoursesHelpBtn";
            myCoursesHelpBtn.Size = new Size(44, 37);
            myCoursesHelpBtn.TabIndex = 8;
            myCoursesHelpBtn.Text = "?";
            myCoursesHelpBtn.UseVisualStyleBackColor = true;
            // 
            // myRegistrationTab
            // 
            myRegistrationTab.BackColor = Color.White;
            myRegistrationTab.Controls.Add(myRegisHelpBtn);
            myRegistrationTab.Location = new Point(4, 29);
            myRegistrationTab.Name = "myRegistrationTab";
            myRegistrationTab.Padding = new Padding(3);
            myRegistrationTab.Size = new Size(622, 793);
            myRegistrationTab.TabIndex = 3;
            myRegistrationTab.Text = "myRegis";
            // 
            // myRegisHelpBtn
            // 
            myRegisHelpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myRegisHelpBtn.Location = new Point(570, 6);
            myRegisHelpBtn.Name = "myRegisHelpBtn";
            myRegisHelpBtn.Size = new Size(44, 37);
            myRegisHelpBtn.TabIndex = 8;
            myRegisHelpBtn.Text = "?";
            myRegisHelpBtn.UseVisualStyleBackColor = true;
            // 
            // myScheduleTab
            // 
            myScheduleTab.BackColor = Color.White;
            myScheduleTab.Controls.Add(myScheduleHelpBtn);
            myScheduleTab.Location = new Point(4, 29);
            myScheduleTab.Name = "myScheduleTab";
            myScheduleTab.Padding = new Padding(3);
            myScheduleTab.Size = new Size(622, 793);
            myScheduleTab.TabIndex = 4;
            myScheduleTab.Text = "mySched";
            // 
            // myScheduleHelpBtn
            // 
            myScheduleHelpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myScheduleHelpBtn.Location = new Point(570, 6);
            myScheduleHelpBtn.Name = "myScheduleHelpBtn";
            myScheduleHelpBtn.Size = new Size(44, 37);
            myScheduleHelpBtn.TabIndex = 8;
            myScheduleHelpBtn.Text = "?";
            myScheduleHelpBtn.UseVisualStyleBackColor = true;
            // 
            // myAdvisorTab
            // 
            myAdvisorTab.BackColor = Color.White;
            myAdvisorTab.Controls.Add(myAdvisorHelpBtn);
            myAdvisorTab.Location = new Point(4, 29);
            myAdvisorTab.Name = "myAdvisorTab";
            myAdvisorTab.Padding = new Padding(3);
            myAdvisorTab.Size = new Size(622, 793);
            myAdvisorTab.TabIndex = 5;
            myAdvisorTab.Text = "myAdv";
            // 
            // myAdvisorHelpBtn
            // 
            myAdvisorHelpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myAdvisorHelpBtn.Location = new Point(570, 6);
            myAdvisorHelpBtn.Name = "myAdvisorHelpBtn";
            myAdvisorHelpBtn.Size = new Size(44, 37);
            myAdvisorHelpBtn.TabIndex = 8;
            myAdvisorHelpBtn.Text = "?";
            myAdvisorHelpBtn.UseVisualStyleBackColor = true;
            // 
            // myPaymentsTab
            // 
            myPaymentsTab.BackColor = Color.White;
            myPaymentsTab.Controls.Add(myPaymentsHelpBtn);
            myPaymentsTab.Location = new Point(4, 29);
            myPaymentsTab.Name = "myPaymentsTab";
            myPaymentsTab.Padding = new Padding(3);
            myPaymentsTab.Size = new Size(622, 793);
            myPaymentsTab.TabIndex = 6;
            myPaymentsTab.Text = "myPay";
            // 
            // myPaymentsHelpBtn
            // 
            myPaymentsHelpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myPaymentsHelpBtn.Location = new Point(570, 6);
            myPaymentsHelpBtn.Name = "myPaymentsHelpBtn";
            myPaymentsHelpBtn.Size = new Size(44, 37);
            myPaymentsHelpBtn.TabIndex = 8;
            myPaymentsHelpBtn.Text = "?";
            myPaymentsHelpBtn.UseVisualStyleBackColor = true;
            // 
            // myProfileTab
            // 
            myProfileTab.BackColor = Color.White;
            myProfileTab.Controls.Add(myProfileHelpBtn);
            myProfileTab.Location = new Point(4, 29);
            myProfileTab.Name = "myProfileTab";
            myProfileTab.Padding = new Padding(3);
            myProfileTab.Size = new Size(622, 793);
            myProfileTab.TabIndex = 7;
            myProfileTab.Text = "myPro";
            // 
            // myProfileHelpBtn
            // 
            myProfileHelpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            myProfileHelpBtn.Location = new Point(570, 6);
            myProfileHelpBtn.Name = "myProfileHelpBtn";
            myProfileHelpBtn.Size = new Size(44, 37);
            myProfileHelpBtn.TabIndex = 8;
            myProfileHelpBtn.Text = "?";
            myProfileHelpBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 813);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            loginTab.ResumeLayout(false);
            loginTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loginLogo).EndInit();
            myHomeTab.ResumeLayout(false);
            myHomeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)myHomeLogo).EndInit();
            myCoursesTab.ResumeLayout(false);
            myRegistrationTab.ResumeLayout(false);
            myScheduleTab.ResumeLayout(false);
            myAdvisorTab.ResumeLayout(false);
            myPaymentsTab.ResumeLayout(false);
            myProfileTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage loginTab;
        private TabPage myHomeTab;
        private TabPage myCoursesTab;
        private TabPage myRegistrationTab;
        private TabPage myScheduleTab;
        private TabPage myAdvisorTab;
        private TabPage myPaymentsTab;
        private TabPage myProfileTab;
        private Button myCoursesBtn;
        private PictureBox myHomeLogo;
        private Button myProfileBtn;
        private Button myPaymentsBtn;
        private Button myAdvisorBtn;
        private Button myScheduleBtn;
        private Button myRegistrationBtn;
        private TextBox textBox1;
        private Button button7;
        private Button loginHelpBtn;
        private TextBox textBox3;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private PictureBox loginLogo;
        private Button myHomeHelpBtn;
        private Button myCoursesHelpBtn;
        private Button myRegisHelpBtn;
        private Button myHomeLogoutBtn;
        private Label ksuLink;
        private Label uitsLink;
        private Button myScheduleHelpBtn;
        private Button myAdvisorHelpBtn;
        private Button myPaymentsHelpBtn;
        private Button myProfileHelpBtn;
    }
}

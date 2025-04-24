namespace myKSU_v3
{
    partial class myCoursesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myCoursesForm));
            courses_mainPnl = new Panel();
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
            panel1 = new Panel();
            courses_semesterLbl = new Label();
            courses_datagridHeaderLbl = new Label();
            chatbot_owlPic = new PictureBox();
            courses_helpBtn = new Button();
            courses_unenrollBtn = new Button();
            courses_backBtn = new Button();
            courseInfo_topPnl = new Panel();
            courseInfo_titleLbl = new Label();
            myCoursesTitlePnl = new Panel();
            courses_titleIcon = new PictureBox();
            coursesTitleLbl = new Label();
            courseInfo_mainPnl = new Panel();
            info_dataTbl = new TableLayoutPanel();
            info_meetingsRow = new TextBox();
            info_codeCell = new TextBox();
            info_deptCell = new TextBox();
            info_descCell = new TextBox();
            info_credCell = new TextBox();
            info_typeCell = new TextBox();
            info_nameRow = new TextBox();
            info_deptRow = new TextBox();
            info_descrRow = new TextBox();
            info_creditsRow = new TextBox();
            info_typeRow = new TextBox();
            info_nameCell = new TextBox();
            info_codeRow = new TextBox();
            info_meetCell = new TextBox();
            courseList_mainPnl = new Panel();
            courses_enrolledList = new ListBox();
            courses_mainPnl.SuspendLayout();
            chatbot_mainPnl.SuspendLayout();
            chatbot_topPnl.SuspendLayout();
            chatbot_replyPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_replyPic).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_owlPic).BeginInit();
            courseInfo_topPnl.SuspendLayout();
            myCoursesTitlePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)courses_titleIcon).BeginInit();
            courseInfo_mainPnl.SuspendLayout();
            info_dataTbl.SuspendLayout();
            courseList_mainPnl.SuspendLayout();
            SuspendLayout();
            // 
            // courses_mainPnl
            // 
            courses_mainPnl.BackColor = Color.Transparent;
            courses_mainPnl.Controls.Add(chatbot_mainPnl);
            courses_mainPnl.Controls.Add(panel1);
            courses_mainPnl.Controls.Add(chatbot_owlPic);
            courses_mainPnl.Controls.Add(courses_helpBtn);
            courses_mainPnl.Controls.Add(courses_unenrollBtn);
            courses_mainPnl.Controls.Add(courses_backBtn);
            courses_mainPnl.Controls.Add(courseInfo_topPnl);
            courses_mainPnl.Controls.Add(myCoursesTitlePnl);
            courses_mainPnl.Controls.Add(courseInfo_mainPnl);
            courses_mainPnl.Controls.Add(courseList_mainPnl);
            courses_mainPnl.Dock = DockStyle.Fill;
            courses_mainPnl.Location = new Point(0, 0);
            courses_mainPnl.Name = "courses_mainPnl";
            courses_mainPnl.Size = new Size(521, 699);
            courses_mainPnl.TabIndex = 18;
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
            chatbot_mainPnl.Location = new Point(95, 391);
            chatbot_mainPnl.Name = "chatbot_mainPnl";
            chatbot_mainPnl.Size = new Size(340, 259);
            chatbot_mainPnl.TabIndex = 48;
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
            chatbot_exitLbl.Location = new Point(316, 1);
            chatbot_exitLbl.Name = "chatbot_exitLbl";
            chatbot_exitLbl.Size = new Size(18, 20);
            chatbot_exitLbl.TabIndex = 3;
            chatbot_exitLbl.Text = "X";
            chatbot_exitLbl.Click += chatbot_exitLbl_Click;
            // 
            // chatbot_helpLbl
            // 
            chatbot_helpLbl.AutoSize = true;
            chatbot_helpLbl.Location = new Point(2, 1);
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
            chatbot_replyPnl.Size = new Size(317, 169);
            chatbot_replyPnl.TabIndex = 34;
            // 
            // chatbot_replyText
            // 
            chatbot_replyText.Location = new Point(36, 5);
            chatbot_replyText.Multiline = true;
            chatbot_replyText.Name = "chatbot_replyText";
            chatbot_replyText.ScrollBars = ScrollBars.Vertical;
            chatbot_replyText.Size = new Size(274, 155);
            chatbot_replyText.TabIndex = 31;
            // 
            // chatbot_replyPic
            // 
            chatbot_replyPic.Image = (Image)resources.GetObject("chatbot_replyPic.Image");
            chatbot_replyPic.Location = new Point(3, 135);
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
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(courses_semesterLbl);
            panel1.Controls.Add(courses_datagridHeaderLbl);
            panel1.Location = new Point(41, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 36);
            panel1.TabIndex = 40;
            // 
            // courses_semesterLbl
            // 
            courses_semesterLbl.AutoSize = true;
            courses_semesterLbl.Location = new Point(203, 9);
            courses_semesterLbl.Name = "courses_semesterLbl";
            courses_semesterLbl.Size = new Size(151, 20);
            courses_semesterLbl.TabIndex = 1;
            courses_semesterLbl.Text = "[registeringSemester]";
            // 
            // courses_datagridHeaderLbl
            // 
            courses_datagridHeaderLbl.AutoSize = true;
            courses_datagridHeaderLbl.Location = new Point(4, 9);
            courses_datagridHeaderLbl.Name = "courses_datagridHeaderLbl";
            courses_datagridHeaderLbl.Size = new Size(203, 20);
            courses_datagridHeaderLbl.TabIndex = 0;
            courses_datagridHeaderLbl.Text = "Courses currently enrolled for";
            // 
            // chatbot_owlPic
            // 
            chatbot_owlPic.BackColor = Color.Transparent;
            chatbot_owlPic.Image = (Image)resources.GetObject("chatbot_owlPic.Image");
            chatbot_owlPic.Location = new Point(441, 637);
            chatbot_owlPic.Name = "chatbot_owlPic";
            chatbot_owlPic.Size = new Size(68, 62);
            chatbot_owlPic.SizeMode = PictureBoxSizeMode.StretchImage;
            chatbot_owlPic.TabIndex = 39;
            chatbot_owlPic.TabStop = false;
            chatbot_owlPic.Click += chatbot_owlPic_Click;
            // 
            // courses_helpBtn
            // 
            courses_helpBtn.BackColor = Color.Gold;
            courses_helpBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courses_helpBtn.ForeColor = Color.Black;
            courses_helpBtn.Location = new Point(44, 634);
            courses_helpBtn.Name = "courses_helpBtn";
            courses_helpBtn.Size = new Size(45, 37);
            courses_helpBtn.TabIndex = 12;
            courses_helpBtn.Text = "?";
            courses_helpBtn.UseVisualStyleBackColor = false;
            courses_helpBtn.Click += courses_helpBtn_Click;
            // 
            // courses_unenrollBtn
            // 
            courses_unenrollBtn.BackColor = Color.Gold;
            courses_unenrollBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courses_unenrollBtn.ForeColor = Color.Black;
            courses_unenrollBtn.Location = new Point(99, 634);
            courses_unenrollBtn.Name = "courses_unenrollBtn";
            courses_unenrollBtn.Size = new Size(171, 37);
            courses_unenrollBtn.TabIndex = 23;
            courses_unenrollBtn.Text = "Unenroll Course";
            courses_unenrollBtn.UseVisualStyleBackColor = false;
            courses_unenrollBtn.Click += courses_unenrollBtn_Click;
            // 
            // courses_backBtn
            // 
            courses_backBtn.BackColor = Color.Gold;
            courses_backBtn.BackgroundImage = (Image)resources.GetObject("courses_backBtn.BackgroundImage");
            courses_backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            courses_backBtn.ForeColor = Color.FromArgb(64, 64, 64);
            courses_backBtn.Location = new Point(464, 12);
            courses_backBtn.Name = "courses_backBtn";
            courses_backBtn.Size = new Size(45, 37);
            courses_backBtn.TabIndex = 13;
            courses_backBtn.UseVisualStyleBackColor = false;
            courses_backBtn.Click += courses_backBtn_Click;
            // 
            // courseInfo_topPnl
            // 
            courseInfo_topPnl.BackColor = Color.White;
            courseInfo_topPnl.BorderStyle = BorderStyle.FixedSingle;
            courseInfo_topPnl.Controls.Add(courseInfo_titleLbl);
            courseInfo_topPnl.Location = new Point(45, 328);
            courseInfo_topPnl.Name = "courseInfo_topPnl";
            courseInfo_topPnl.Size = new Size(104, 33);
            courseInfo_topPnl.TabIndex = 0;
            // 
            // courseInfo_titleLbl
            // 
            courseInfo_titleLbl.AutoSize = true;
            courseInfo_titleLbl.Font = new Font("Century Schoolbook", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            courseInfo_titleLbl.ForeColor = Color.Gold;
            courseInfo_titleLbl.Location = new Point(8, 4);
            courseInfo_titleLbl.Name = "courseInfo_titleLbl";
            courseInfo_titleLbl.Size = new Size(85, 25);
            courseInfo_titleLbl.TabIndex = 1;
            courseInfo_titleLbl.Text = "Details";
            // 
            // myCoursesTitlePnl
            // 
            myCoursesTitlePnl.BackColor = Color.White;
            myCoursesTitlePnl.BorderStyle = BorderStyle.FixedSingle;
            myCoursesTitlePnl.Controls.Add(courses_titleIcon);
            myCoursesTitlePnl.Controls.Add(coursesTitleLbl);
            myCoursesTitlePnl.Location = new Point(41, 23);
            myCoursesTitlePnl.Name = "myCoursesTitlePnl";
            myCoursesTitlePnl.Size = new Size(200, 37);
            myCoursesTitlePnl.TabIndex = 22;
            // 
            // courses_titleIcon
            // 
            courses_titleIcon.Image = (Image)resources.GetObject("courses_titleIcon.Image");
            courses_titleIcon.Location = new Point(2, 1);
            courses_titleIcon.Name = "courses_titleIcon";
            courses_titleIcon.Size = new Size(43, 33);
            courses_titleIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            courses_titleIcon.TabIndex = 23;
            courses_titleIcon.TabStop = false;
            // 
            // coursesTitleLbl
            // 
            coursesTitleLbl.AutoSize = true;
            coursesTitleLbl.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            coursesTitleLbl.ForeColor = Color.Gold;
            coursesTitleLbl.Location = new Point(50, 3);
            coursesTitleLbl.Name = "coursesTitleLbl";
            coursesTitleLbl.Size = new Size(145, 27);
            coursesTitleLbl.TabIndex = 0;
            coursesTitleLbl.Text = "myCourses";
            // 
            // courseInfo_mainPnl
            // 
            courseInfo_mainPnl.BackColor = Color.White;
            courseInfo_mainPnl.BorderStyle = BorderStyle.FixedSingle;
            courseInfo_mainPnl.Controls.Add(info_dataTbl);
            courseInfo_mainPnl.Location = new Point(45, 361);
            courseInfo_mainPnl.Name = "courseInfo_mainPnl";
            courseInfo_mainPnl.Size = new Size(425, 267);
            courseInfo_mainPnl.TabIndex = 21;
            // 
            // info_dataTbl
            // 
            info_dataTbl.ColumnCount = 2;
            info_dataTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.29833F));
            info_dataTbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.70167F));
            info_dataTbl.Controls.Add(info_meetingsRow, 0, 6);
            info_dataTbl.Controls.Add(info_codeCell, 1, 0);
            info_dataTbl.Controls.Add(info_deptCell, 1, 2);
            info_dataTbl.Controls.Add(info_descCell, 1, 3);
            info_dataTbl.Controls.Add(info_credCell, 1, 4);
            info_dataTbl.Controls.Add(info_typeCell, 1, 5);
            info_dataTbl.Controls.Add(info_nameRow, 0, 1);
            info_dataTbl.Controls.Add(info_deptRow, 0, 2);
            info_dataTbl.Controls.Add(info_descrRow, 0, 3);
            info_dataTbl.Controls.Add(info_creditsRow, 0, 4);
            info_dataTbl.Controls.Add(info_typeRow, 0, 5);
            info_dataTbl.Controls.Add(info_nameCell, 1, 1);
            info_dataTbl.Controls.Add(info_codeRow, 0, 0);
            info_dataTbl.Controls.Add(info_meetCell, 1, 6);
            info_dataTbl.Dock = DockStyle.Fill;
            info_dataTbl.Location = new Point(0, 0);
            info_dataTbl.Name = "info_dataTbl";
            info_dataTbl.RowCount = 7;
            info_dataTbl.RowStyles.Add(new RowStyle());
            info_dataTbl.RowStyles.Add(new RowStyle());
            info_dataTbl.RowStyles.Add(new RowStyle());
            info_dataTbl.RowStyles.Add(new RowStyle());
            info_dataTbl.RowStyles.Add(new RowStyle());
            info_dataTbl.RowStyles.Add(new RowStyle());
            info_dataTbl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            info_dataTbl.Size = new Size(423, 265);
            info_dataTbl.TabIndex = 1;
            // 
            // info_meetingsRow
            // 
            info_meetingsRow.BackColor = Color.White;
            info_meetingsRow.Location = new Point(3, 201);
            info_meetingsRow.Multiline = true;
            info_meetingsRow.Name = "info_meetingsRow";
            info_meetingsRow.PlaceholderText = "Meetings:";
            info_meetingsRow.ReadOnly = true;
            info_meetingsRow.Size = new Size(100, 27);
            info_meetingsRow.TabIndex = 31;
            // 
            // info_codeCell
            // 
            info_codeCell.BackColor = Color.White;
            info_codeCell.Dock = DockStyle.Fill;
            info_codeCell.Location = new Point(110, 3);
            info_codeCell.Name = "info_codeCell";
            info_codeCell.ReadOnly = true;
            info_codeCell.Size = new Size(310, 27);
            info_codeCell.TabIndex = 17;
            // 
            // info_deptCell
            // 
            info_deptCell.BackColor = Color.White;
            info_deptCell.Dock = DockStyle.Fill;
            info_deptCell.Location = new Point(110, 69);
            info_deptCell.Name = "info_deptCell";
            info_deptCell.ReadOnly = true;
            info_deptCell.Size = new Size(310, 27);
            info_deptCell.TabIndex = 19;
            // 
            // info_descCell
            // 
            info_descCell.BackColor = Color.White;
            info_descCell.Dock = DockStyle.Fill;
            info_descCell.Location = new Point(110, 102);
            info_descCell.Name = "info_descCell";
            info_descCell.ReadOnly = true;
            info_descCell.Size = new Size(310, 27);
            info_descCell.TabIndex = 20;
            // 
            // info_credCell
            // 
            info_credCell.BackColor = Color.White;
            info_credCell.Dock = DockStyle.Fill;
            info_credCell.Location = new Point(110, 135);
            info_credCell.Name = "info_credCell";
            info_credCell.ReadOnly = true;
            info_credCell.Size = new Size(310, 27);
            info_credCell.TabIndex = 21;
            // 
            // info_typeCell
            // 
            info_typeCell.BackColor = Color.White;
            info_typeCell.Dock = DockStyle.Fill;
            info_typeCell.Location = new Point(110, 168);
            info_typeCell.Name = "info_typeCell";
            info_typeCell.ReadOnly = true;
            info_typeCell.Size = new Size(310, 27);
            info_typeCell.TabIndex = 22;
            // 
            // info_nameRow
            // 
            info_nameRow.BackColor = Color.White;
            info_nameRow.Location = new Point(3, 36);
            info_nameRow.Name = "info_nameRow";
            info_nameRow.PlaceholderText = "Name:";
            info_nameRow.ReadOnly = true;
            info_nameRow.Size = new Size(100, 27);
            info_nameRow.TabIndex = 25;
            // 
            // info_deptRow
            // 
            info_deptRow.BackColor = Color.White;
            info_deptRow.Location = new Point(3, 69);
            info_deptRow.Name = "info_deptRow";
            info_deptRow.PlaceholderText = "Department:";
            info_deptRow.ReadOnly = true;
            info_deptRow.Size = new Size(100, 27);
            info_deptRow.TabIndex = 26;
            // 
            // info_descrRow
            // 
            info_descrRow.BackColor = Color.White;
            info_descrRow.Location = new Point(3, 102);
            info_descrRow.Name = "info_descrRow";
            info_descrRow.PlaceholderText = "Description:";
            info_descrRow.ReadOnly = true;
            info_descrRow.Size = new Size(100, 27);
            info_descrRow.TabIndex = 27;
            // 
            // info_creditsRow
            // 
            info_creditsRow.BackColor = Color.White;
            info_creditsRow.Location = new Point(3, 135);
            info_creditsRow.Name = "info_creditsRow";
            info_creditsRow.PlaceholderText = "Credits:";
            info_creditsRow.ReadOnly = true;
            info_creditsRow.Size = new Size(100, 27);
            info_creditsRow.TabIndex = 28;
            // 
            // info_typeRow
            // 
            info_typeRow.BackColor = Color.White;
            info_typeRow.Location = new Point(3, 168);
            info_typeRow.Name = "info_typeRow";
            info_typeRow.PlaceholderText = "Type:";
            info_typeRow.ReadOnly = true;
            info_typeRow.Size = new Size(100, 27);
            info_typeRow.TabIndex = 29;
            // 
            // info_nameCell
            // 
            info_nameCell.BackColor = Color.White;
            info_nameCell.Dock = DockStyle.Fill;
            info_nameCell.Location = new Point(110, 36);
            info_nameCell.Name = "info_nameCell";
            info_nameCell.ReadOnly = true;
            info_nameCell.Size = new Size(310, 27);
            info_nameCell.TabIndex = 18;
            // 
            // info_codeRow
            // 
            info_codeRow.BackColor = Color.White;
            info_codeRow.Location = new Point(3, 3);
            info_codeRow.Name = "info_codeRow";
            info_codeRow.PlaceholderText = "Code:";
            info_codeRow.ReadOnly = true;
            info_codeRow.Size = new Size(100, 27);
            info_codeRow.TabIndex = 24;
            // 
            // info_meetCell
            // 
            info_meetCell.BackColor = Color.White;
            info_meetCell.Location = new Point(110, 201);
            info_meetCell.Multiline = true;
            info_meetCell.Name = "info_meetCell";
            info_meetCell.ReadOnly = true;
            info_meetCell.ScrollBars = ScrollBars.Vertical;
            info_meetCell.Size = new Size(307, 61);
            info_meetCell.TabIndex = 30;
            // 
            // courseList_mainPnl
            // 
            courseList_mainPnl.BackColor = Color.White;
            courseList_mainPnl.Controls.Add(courses_enrolledList);
            courseList_mainPnl.Location = new Point(41, 96);
            courseList_mainPnl.Name = "courseList_mainPnl";
            courseList_mainPnl.Size = new Size(425, 226);
            courseList_mainPnl.TabIndex = 19;
            // 
            // courses_enrolledList
            // 
            courses_enrolledList.Dock = DockStyle.Fill;
            courses_enrolledList.FormattingEnabled = true;
            courses_enrolledList.HorizontalScrollbar = true;
            courses_enrolledList.Location = new Point(0, 0);
            courses_enrolledList.Name = "courses_enrolledList";
            courses_enrolledList.ScrollAlwaysVisible = true;
            courses_enrolledList.Size = new Size(425, 226);
            courses_enrolledList.TabIndex = 2;
            // 
            // myCoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(521, 699);
            Controls.Add(courses_mainPnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(539, 746);
            MinimumSize = new Size(539, 746);
            Name = "myCoursesForm";
            Text = "[ myCourses ]";
            courses_mainPnl.ResumeLayout(false);
            chatbot_mainPnl.ResumeLayout(false);
            chatbot_mainPnl.PerformLayout();
            chatbot_topPnl.ResumeLayout(false);
            chatbot_topPnl.PerformLayout();
            chatbot_replyPnl.ResumeLayout(false);
            chatbot_replyPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_replyPic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_owlPic).EndInit();
            courseInfo_topPnl.ResumeLayout(false);
            courseInfo_topPnl.PerformLayout();
            myCoursesTitlePnl.ResumeLayout(false);
            myCoursesTitlePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)courses_titleIcon).EndInit();
            courseInfo_mainPnl.ResumeLayout(false);
            info_dataTbl.ResumeLayout(false);
            info_dataTbl.PerformLayout();
            courseList_mainPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label home_ksuLink;
        private Label home_uitsLink;
        private Panel courses_mainPnl;
        private Button courses_helpBtn;
        private Button courses_backBtn;
        private Panel courseList_mainPnl;
        private ListBox courses_enrolledList;
        private Panel courseInfo_mainPnl;
        private Panel courseInfo_topPnl;
        private Label courseInfo_titleLbl;
        private TableLayoutPanel info_dataTbl;
        private TextBox info_codeCell;
        private TextBox info_nameCell;
        private TextBox info_deptCell;
        private TextBox info_descCell;
        private TextBox info_credCell;
        private TextBox info_typeCell;
        private TextBox info_nameRow;
        private TextBox info_deptRow;
        private TextBox info_descrRow;
        private TextBox info_creditsRow;
        private TextBox info_typeRow;
        private TextBox info_codeRow;
        private Button courses_unenrollBtn;
        private ListBox listBox1;
        private Label courses_infoLbl;
        private TextBox info_meetingsRow;
        private TextBox info_meetCell;
        private PictureBox courses_titleIcon;
        private Panel myCoursesTitlePnl;
        private Label coursesTitleLbl;
        private PictureBox chatbot_owlPic;
        private Panel panel1;
        private Label courses_semesterLbl;
        private Label courses_datagridHeaderLbl;
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
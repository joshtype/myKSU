namespace myKSU_v3
{
    partial class myRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myRegistrationForm));
            registration_enrollBtn = new Button();
            registration_mainPnl = new Panel();
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
            registration_helpBtn = new Button();
            results_titlePnl = new Panel();
            results_titleIcon = new PictureBox();
            results_titleLbl = new Label();
            registration_resetBtn = new Button();
            registration_backBtn = new Button();
            registration_catalogDataGrid = new DataGridView();
            code = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            dept = new DataGridViewTextBoxColumn();
            credits = new DataGridViewTextBoxColumn();
            day = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            registration_titlePnl = new Panel();
            registration_titleIcon = new PictureBox();
            registration_titleLbl = new Label();
            registration_searchPnl = new Panel();
            label1 = new Label();
            registration_deptSelection = new ComboBox();
            registration_searchBtn = new Button();
            registration_semesterLbl = new Label();
            registration_semesterSelection = new ComboBox();
            registration_searchLbl = new Label();
            registration_searchBox = new TextBox();
            registration_recommendedBtn = new Button();
            registration_mainPnl.SuspendLayout();
            chatbot_mainPnl.SuspendLayout();
            chatbot_topPnl.SuspendLayout();
            chatbot_replyPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_replyPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatbot_owlPic).BeginInit();
            results_titlePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)results_titleIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)registration_catalogDataGrid).BeginInit();
            registration_titlePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)registration_titleIcon).BeginInit();
            registration_searchPnl.SuspendLayout();
            SuspendLayout();
            // 
            // registration_enrollBtn
            // 
            registration_enrollBtn.BackColor = Color.Gold;
            registration_enrollBtn.Font = new Font("Segoe UI", 10.2F);
            registration_enrollBtn.ForeColor = Color.Black;
            registration_enrollBtn.Location = new Point(61, 629);
            registration_enrollBtn.Name = "registration_enrollBtn";
            registration_enrollBtn.Size = new Size(138, 37);
            registration_enrollBtn.TabIndex = 23;
            registration_enrollBtn.Text = "Enroll Course";
            registration_enrollBtn.UseVisualStyleBackColor = false;
            registration_enrollBtn.Click += registration_enrollBtn_Click;
            // 
            // registration_mainPnl
            // 
            registration_mainPnl.BackColor = Color.White;
            registration_mainPnl.BackgroundImage = (Image)resources.GetObject("registration_mainPnl.BackgroundImage");
            registration_mainPnl.Controls.Add(chatbot_mainPnl);
            registration_mainPnl.Controls.Add(chatbot_owlPic);
            registration_mainPnl.Controls.Add(registration_helpBtn);
            registration_mainPnl.Controls.Add(results_titlePnl);
            registration_mainPnl.Controls.Add(registration_resetBtn);
            registration_mainPnl.Controls.Add(registration_backBtn);
            registration_mainPnl.Controls.Add(registration_catalogDataGrid);
            registration_mainPnl.Controls.Add(registration_titlePnl);
            registration_mainPnl.Controls.Add(registration_searchPnl);
            registration_mainPnl.Controls.Add(registration_enrollBtn);
            registration_mainPnl.Dock = DockStyle.Fill;
            registration_mainPnl.Location = new Point(0, 0);
            registration_mainPnl.Name = "registration_mainPnl";
            registration_mainPnl.Size = new Size(521, 699);
            registration_mainPnl.TabIndex = 27;
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
            chatbot_mainPnl.TabIndex = 46;
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
            chatbot_owlPic.TabIndex = 37;
            chatbot_owlPic.TabStop = false;
            chatbot_owlPic.Click += chatbot_owlPic_Click;
            // 
            // registration_helpBtn
            // 
            registration_helpBtn.BackColor = Color.Gold;
            registration_helpBtn.Font = new Font("Segoe UI", 10.2F);
            registration_helpBtn.ForeColor = Color.Black;
            registration_helpBtn.Location = new Point(10, 629);
            registration_helpBtn.Name = "registration_helpBtn";
            registration_helpBtn.Size = new Size(45, 37);
            registration_helpBtn.TabIndex = 12;
            registration_helpBtn.Text = "?";
            registration_helpBtn.UseVisualStyleBackColor = false;
            registration_helpBtn.Click += registration_helpBtn_Click;
            // 
            // results_titlePnl
            // 
            results_titlePnl.BackColor = Color.White;
            results_titlePnl.BorderStyle = BorderStyle.FixedSingle;
            results_titlePnl.Controls.Add(results_titleIcon);
            results_titlePnl.Controls.Add(results_titleLbl);
            results_titlePnl.Location = new Point(10, 236);
            results_titlePnl.Name = "results_titlePnl";
            results_titlePnl.Size = new Size(259, 40);
            results_titlePnl.TabIndex = 33;
            // 
            // results_titleIcon
            // 
            results_titleIcon.Image = (Image)resources.GetObject("results_titleIcon.Image");
            results_titleIcon.Location = new Point(6, 3);
            results_titleIcon.Name = "results_titleIcon";
            results_titleIcon.Size = new Size(40, 32);
            results_titleIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            results_titleIcon.TabIndex = 23;
            results_titleIcon.TabStop = false;
            // 
            // results_titleLbl
            // 
            results_titleLbl.AutoSize = true;
            results_titleLbl.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            results_titleLbl.ForeColor = Color.Gold;
            results_titleLbl.Location = new Point(52, 6);
            results_titleLbl.Name = "results_titleLbl";
            results_titleLbl.Size = new Size(192, 27);
            results_titleLbl.TabIndex = 0;
            results_titleLbl.Text = "Search Results";
            // 
            // registration_resetBtn
            // 
            registration_resetBtn.BackColor = Color.Gold;
            registration_resetBtn.Font = new Font("Segoe UI", 10.2F);
            registration_resetBtn.ForeColor = Color.Black;
            registration_resetBtn.Location = new Point(445, 219);
            registration_resetBtn.Name = "registration_resetBtn";
            registration_resetBtn.Size = new Size(64, 36);
            registration_resetBtn.TabIndex = 30;
            registration_resetBtn.Text = "Reset";
            registration_resetBtn.UseVisualStyleBackColor = false;
            registration_resetBtn.Click += registration_resetBtn_Click;
            // 
            // registration_backBtn
            // 
            registration_backBtn.BackColor = Color.Gold;
            registration_backBtn.BackgroundImage = (Image)resources.GetObject("registration_backBtn.BackgroundImage");
            registration_backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            registration_backBtn.ForeColor = Color.FromArgb(64, 64, 64);
            registration_backBtn.Location = new Point(464, 12);
            registration_backBtn.Name = "registration_backBtn";
            registration_backBtn.Size = new Size(45, 37);
            registration_backBtn.TabIndex = 13;
            registration_backBtn.UseVisualStyleBackColor = false;
            registration_backBtn.Click += registration_backBtn_Click;
            // 
            // registration_catalogDataGrid
            // 
            registration_catalogDataGrid.AllowUserToAddRows = false;
            registration_catalogDataGrid.AllowUserToDeleteRows = false;
            registration_catalogDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            registration_catalogDataGrid.BackgroundColor = Color.White;
            registration_catalogDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registration_catalogDataGrid.Columns.AddRange(new DataGridViewColumn[] { code, name, dept, credits, day, time });
            registration_catalogDataGrid.Location = new Point(11, 276);
            registration_catalogDataGrid.Name = "registration_catalogDataGrid";
            registration_catalogDataGrid.ReadOnly = true;
            registration_catalogDataGrid.RowHeadersVisible = false;
            registration_catalogDataGrid.RowHeadersWidth = 51;
            registration_catalogDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            registration_catalogDataGrid.Size = new Size(498, 346);
            registration_catalogDataGrid.TabIndex = 33;
            // 
            // code
            // 
            code.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            code.HeaderText = "Code";
            code.MinimumWidth = 6;
            code.Name = "code";
            code.ReadOnly = true;
            code.Width = 73;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // dept
            // 
            dept.HeaderText = "Dept";
            dept.MinimumWidth = 6;
            dept.Name = "dept";
            dept.ReadOnly = true;
            // 
            // credits
            // 
            credits.HeaderText = "Crdts";
            credits.MinimumWidth = 6;
            credits.Name = "credits";
            credits.ReadOnly = true;
            // 
            // day
            // 
            day.HeaderText = "Day";
            day.MinimumWidth = 6;
            day.Name = "day";
            day.ReadOnly = true;
            // 
            // time
            // 
            time.HeaderText = "Time";
            time.MinimumWidth = 6;
            time.Name = "time";
            time.ReadOnly = true;
            // 
            // registration_titlePnl
            // 
            registration_titlePnl.BackColor = Color.White;
            registration_titlePnl.BorderStyle = BorderStyle.FixedSingle;
            registration_titlePnl.Controls.Add(registration_titleIcon);
            registration_titlePnl.Controls.Add(registration_titleLbl);
            registration_titlePnl.Location = new Point(11, 38);
            registration_titlePnl.Name = "registration_titlePnl";
            registration_titlePnl.Size = new Size(256, 40);
            registration_titlePnl.TabIndex = 32;
            // 
            // registration_titleIcon
            // 
            registration_titleIcon.Image = (Image)resources.GetObject("registration_titleIcon.Image");
            registration_titleIcon.Location = new Point(6, 3);
            registration_titleIcon.Name = "registration_titleIcon";
            registration_titleIcon.Size = new Size(40, 32);
            registration_titleIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            registration_titleIcon.TabIndex = 23;
            registration_titleIcon.TabStop = false;
            // 
            // registration_titleLbl
            // 
            registration_titleLbl.AutoSize = true;
            registration_titleLbl.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registration_titleLbl.ForeColor = Color.Gold;
            registration_titleLbl.Location = new Point(52, 6);
            registration_titleLbl.Name = "registration_titleLbl";
            registration_titleLbl.Size = new Size(200, 27);
            registration_titleLbl.TabIndex = 0;
            registration_titleLbl.Text = "myRegistration";
            // 
            // registration_searchPnl
            // 
            registration_searchPnl.BorderStyle = BorderStyle.FixedSingle;
            registration_searchPnl.Controls.Add(label1);
            registration_searchPnl.Controls.Add(registration_deptSelection);
            registration_searchPnl.Controls.Add(registration_searchBtn);
            registration_searchPnl.Controls.Add(registration_semesterLbl);
            registration_searchPnl.Controls.Add(registration_semesterSelection);
            registration_searchPnl.Controls.Add(registration_searchLbl);
            registration_searchPnl.Controls.Add(registration_searchBox);
            registration_searchPnl.Controls.Add(registration_recommendedBtn);
            registration_searchPnl.Location = new Point(11, 77);
            registration_searchPnl.Name = "registration_searchPnl";
            registration_searchPnl.Size = new Size(498, 136);
            registration_searchPnl.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 70);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 34;
            label1.Text = "View Dept:";
            // 
            // registration_deptSelection
            // 
            registration_deptSelection.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registration_deptSelection.FormattingEnabled = true;
            registration_deptSelection.Items.AddRange(new object[] { "All Departments", "Computer Science", "History", "Humanities", "English & Literature", "Mathematics", "Science" });
            registration_deptSelection.Location = new Point(15, 91);
            registration_deptSelection.Name = "registration_deptSelection";
            registration_deptSelection.Size = new Size(172, 29);
            registration_deptSelection.TabIndex = 33;
            registration_deptSelection.SelectedIndexChanged += registration_deptSelection_SelectedIndexChanged;
            // 
            // registration_searchBtn
            // 
            registration_searchBtn.BackColor = Color.Gold;
            registration_searchBtn.BackgroundImage = (Image)resources.GetObject("registration_searchBtn.BackgroundImage");
            registration_searchBtn.BackgroundImageLayout = ImageLayout.Stretch;
            registration_searchBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registration_searchBtn.ForeColor = Color.Black;
            registration_searchBtn.Location = new Point(444, 28);
            registration_searchBtn.Name = "registration_searchBtn";
            registration_searchBtn.Size = new Size(43, 35);
            registration_searchBtn.TabIndex = 32;
            registration_searchBtn.UseVisualStyleBackColor = false;
            registration_searchBtn.Click += registration_searchBtn_Click;
            // 
            // registration_semesterLbl
            // 
            registration_semesterLbl.AutoSize = true;
            registration_semesterLbl.Location = new Point(15, 9);
            registration_semesterLbl.Name = "registration_semesterLbl";
            registration_semesterLbl.Size = new Size(73, 20);
            registration_semesterLbl.TabIndex = 31;
            registration_semesterLbl.Text = "Semester:";
            // 
            // registration_semesterSelection
            // 
            registration_semesterSelection.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registration_semesterSelection.FormattingEnabled = true;
            registration_semesterSelection.Items.AddRange(new object[] { "FALL 2026" });
            registration_semesterSelection.Location = new Point(15, 31);
            registration_semesterSelection.Name = "registration_semesterSelection";
            registration_semesterSelection.Size = new Size(172, 29);
            registration_semesterSelection.TabIndex = 30;
            // 
            // registration_searchLbl
            // 
            registration_searchLbl.AutoSize = true;
            registration_searchLbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registration_searchLbl.Location = new Point(224, 9);
            registration_searchLbl.Name = "registration_searchLbl";
            registration_searchLbl.Size = new Size(56, 20);
            registration_searchLbl.TabIndex = 28;
            registration_searchLbl.Text = "Search:";
            // 
            // registration_searchBox
            // 
            registration_searchBox.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            registration_searchBox.Location = new Point(224, 32);
            registration_searchBox.Name = "registration_searchBox";
            registration_searchBox.Size = new Size(216, 28);
            registration_searchBox.TabIndex = 27;
            // 
            // registration_recommendedBtn
            // 
            registration_recommendedBtn.BackColor = Color.Gold;
            registration_recommendedBtn.Font = new Font("Segoe UI", 10.2F);
            registration_recommendedBtn.ForeColor = Color.Black;
            registration_recommendedBtn.Location = new Point(224, 86);
            registration_recommendedBtn.Name = "registration_recommendedBtn";
            registration_recommendedBtn.Size = new Size(263, 36);
            registration_recommendedBtn.TabIndex = 26;
            registration_recommendedBtn.Text = "View Recommended Courses";
            registration_recommendedBtn.UseVisualStyleBackColor = false;
            registration_recommendedBtn.Click += registration_recommendedBtn_Click;
            // 
            // myRegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 699);
            Controls.Add(registration_mainPnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(539, 746);
            MinimumSize = new Size(539, 746);
            Name = "myRegistrationForm";
            Text = "[ myRegistration ]";
            registration_mainPnl.ResumeLayout(false);
            chatbot_mainPnl.ResumeLayout(false);
            chatbot_mainPnl.PerformLayout();
            chatbot_topPnl.ResumeLayout(false);
            chatbot_topPnl.PerformLayout();
            chatbot_replyPnl.ResumeLayout(false);
            chatbot_replyPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_replyPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatbot_owlPic).EndInit();
            results_titlePnl.ResumeLayout(false);
            results_titlePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)results_titleIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)registration_catalogDataGrid).EndInit();
            registration_titlePnl.ResumeLayout(false);
            registration_titlePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)registration_titleIcon).EndInit();
            registration_searchPnl.ResumeLayout(false);
            registration_searchPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button registration_enrollBtn;
        private Panel registration_topPnl;
        private Label registration_titleLbl;
        private Panel registration_mainPnl;
        private Panel registration_searchPnl;
        private Button registration_recommendedBtn;
        private Label registration_searchLbl;
        private TextBox registration_searchBox;
        private Button registration_helpBtn;
        private Button registration_backBtn;
        private Button registration_resetBtn;
        private ComboBox registration_semesterSelection;
        private Label registration_semesterLbl;
        private Panel registration_titlePnl;
        private PictureBox registration_titleIcon;
        private DataGridView registration_catalogDataGrid;
        private Panel results_titlePnl;
        private PictureBox results_titleIcon;
        private Label results_titleLbl;
        private Button registration_searchBtn;
        private ComboBox registration_deptSelection;
        private Label label1;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn dept;
        private DataGridViewTextBoxColumn credits;
        private DataGridViewTextBoxColumn day;
        private DataGridViewTextBoxColumn time;
        private PictureBox chatbot_owlPic;
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
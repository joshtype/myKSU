namespace myKSU_v3
{
    partial class myScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myScheduleForm));
            schedule_mainPnl = new Panel();
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
            schedule_helpBtn = new Button();
            schedule_exportBtn = new Button();
            schedule_backBtn = new Button();
            schedule_titlePnl = new Panel();
            schedule_titleIcon = new PictureBox();
            schedule_titleLbl = new Label();
            schedule_dataGrid = new DataGridView();
            day = new DataGridViewTextBoxColumn();
            time = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            code = new DataGridViewTextBoxColumn();
            label1 = new Label();
            schedule_mainPnl.SuspendLayout();
            chatbot_mainPnl.SuspendLayout();
            chatbot_topPnl.SuspendLayout();
            chatbot_replyPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_replyPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chatbot_owlPic).BeginInit();
            schedule_titlePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)schedule_titleIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)schedule_dataGrid).BeginInit();
            SuspendLayout();
            // 
            // schedule_mainPnl
            // 
            schedule_mainPnl.BackgroundImage = (Image)resources.GetObject("schedule_mainPnl.BackgroundImage");
            schedule_mainPnl.Controls.Add(label1);
            schedule_mainPnl.Controls.Add(chatbot_mainPnl);
            schedule_mainPnl.Controls.Add(chatbot_owlPic);
            schedule_mainPnl.Controls.Add(schedule_helpBtn);
            schedule_mainPnl.Controls.Add(schedule_exportBtn);
            schedule_mainPnl.Controls.Add(schedule_backBtn);
            schedule_mainPnl.Controls.Add(schedule_titlePnl);
            schedule_mainPnl.Controls.Add(schedule_dataGrid);
            schedule_mainPnl.Dock = DockStyle.Fill;
            schedule_mainPnl.Location = new Point(0, 0);
            schedule_mainPnl.Name = "schedule_mainPnl";
            schedule_mainPnl.Size = new Size(521, 699);
            schedule_mainPnl.TabIndex = 24;
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
            chatbot_mainPnl.TabIndex = 47;
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
            chatbot_exitLbl.Location = new Point(316, 3);
            chatbot_exitLbl.Name = "chatbot_exitLbl";
            chatbot_exitLbl.Size = new Size(18, 20);
            chatbot_exitLbl.TabIndex = 3;
            chatbot_exitLbl.Text = "X";
            // 
            // chatbot_helpLbl
            // 
            chatbot_helpLbl.AutoSize = true;
            chatbot_helpLbl.Location = new Point(2, 3);
            chatbot_helpLbl.Name = "chatbot_helpLbl";
            chatbot_helpLbl.Size = new Size(16, 20);
            chatbot_helpLbl.TabIndex = 2;
            chatbot_helpLbl.Text = "?";
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
            // schedule_helpBtn
            // 
            schedule_helpBtn.BackColor = Color.Gold;
            schedule_helpBtn.Font = new Font("Segoe UI", 10.2F);
            schedule_helpBtn.ForeColor = Color.Black;
            schedule_helpBtn.Location = new Point(12, 614);
            schedule_helpBtn.Name = "schedule_helpBtn";
            schedule_helpBtn.Size = new Size(45, 37);
            schedule_helpBtn.TabIndex = 24;
            schedule_helpBtn.Text = "?";
            schedule_helpBtn.UseVisualStyleBackColor = false;
            schedule_helpBtn.Click += schedule_helpBtn_Click;
            // 
            // schedule_exportBtn
            // 
            schedule_exportBtn.BackColor = Color.Gold;
            schedule_exportBtn.Font = new Font("Segoe UI", 10.2F);
            schedule_exportBtn.ForeColor = Color.Black;
            schedule_exportBtn.Location = new Point(63, 614);
            schedule_exportBtn.Name = "schedule_exportBtn";
            schedule_exportBtn.Size = new Size(127, 37);
            schedule_exportBtn.TabIndex = 27;
            schedule_exportBtn.Text = "Export to PDF";
            schedule_exportBtn.UseVisualStyleBackColor = false;
            schedule_exportBtn.Click += schedule_exportBtn_Click;
            // 
            // schedule_backBtn
            // 
            schedule_backBtn.BackColor = Color.Gold;
            schedule_backBtn.BackgroundImage = (Image)resources.GetObject("schedule_backBtn.BackgroundImage");
            schedule_backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            schedule_backBtn.ForeColor = Color.FromArgb(64, 64, 64);
            schedule_backBtn.Location = new Point(464, 12);
            schedule_backBtn.Name = "schedule_backBtn";
            schedule_backBtn.Size = new Size(45, 37);
            schedule_backBtn.TabIndex = 25;
            schedule_backBtn.UseVisualStyleBackColor = false;
            schedule_backBtn.Click += schedule_backBtn_Click;
            // 
            // schedule_titlePnl
            // 
            schedule_titlePnl.BackColor = Color.White;
            schedule_titlePnl.BorderStyle = BorderStyle.FixedSingle;
            schedule_titlePnl.Controls.Add(schedule_titleIcon);
            schedule_titlePnl.Controls.Add(schedule_titleLbl);
            schedule_titlePnl.Location = new Point(12, 27);
            schedule_titlePnl.Name = "schedule_titlePnl";
            schedule_titlePnl.Size = new Size(218, 40);
            schedule_titlePnl.TabIndex = 28;
            // 
            // schedule_titleIcon
            // 
            schedule_titleIcon.Image = (Image)resources.GetObject("schedule_titleIcon.Image");
            schedule_titleIcon.Location = new Point(2, 3);
            schedule_titleIcon.Name = "schedule_titleIcon";
            schedule_titleIcon.Size = new Size(44, 34);
            schedule_titleIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            schedule_titleIcon.TabIndex = 23;
            schedule_titleIcon.TabStop = false;
            // 
            // schedule_titleLbl
            // 
            schedule_titleLbl.AutoSize = true;
            schedule_titleLbl.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            schedule_titleLbl.ForeColor = Color.Gold;
            schedule_titleLbl.Location = new Point(52, 6);
            schedule_titleLbl.Name = "schedule_titleLbl";
            schedule_titleLbl.Size = new Size(157, 27);
            schedule_titleLbl.TabIndex = 0;
            schedule_titleLbl.Text = "mySchedule";
            // 
            // schedule_dataGrid
            // 
            schedule_dataGrid.AllowUserToAddRows = false;
            schedule_dataGrid.AllowUserToDeleteRows = false;
            schedule_dataGrid.BackgroundColor = Color.White;
            schedule_dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            schedule_dataGrid.Columns.AddRange(new DataGridViewColumn[] { day, time, name, code });
            schedule_dataGrid.Location = new Point(12, 67);
            schedule_dataGrid.Name = "schedule_dataGrid";
            schedule_dataGrid.ReadOnly = true;
            schedule_dataGrid.RowHeadersVisible = false;
            schedule_dataGrid.RowHeadersWidth = 51;
            schedule_dataGrid.Size = new Size(497, 541);
            schedule_dataGrid.TabIndex = 26;
            // 
            // day
            // 
            day.HeaderText = "Day";
            day.MinimumWidth = 6;
            day.Name = "day";
            day.ReadOnly = true;
            day.Width = 124;
            // 
            // time
            // 
            time.HeaderText = "Time";
            time.MinimumWidth = 6;
            time.Name = "time";
            time.ReadOnly = true;
            time.Width = 123;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 124;
            // 
            // code
            // 
            code.HeaderText = "Code";
            code.MinimumWidth = 6;
            code.Name = "code";
            code.ReadOnly = true;
            code.Width = 123;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(234, 47);
            label1.Name = "label1";
            label1.Size = new Size(191, 20);
            label1.TabIndex = 48;
            label1.Text = "*Resize columns as needed.";
            // 
            // myScheduleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 699);
            Controls.Add(schedule_mainPnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(539, 746);
            MinimumSize = new Size(539, 746);
            Name = "myScheduleForm";
            Text = "[ mySchedule ]";
            schedule_mainPnl.ResumeLayout(false);
            schedule_mainPnl.PerformLayout();
            chatbot_mainPnl.ResumeLayout(false);
            chatbot_mainPnl.PerformLayout();
            chatbot_topPnl.ResumeLayout(false);
            chatbot_topPnl.PerformLayout();
            chatbot_replyPnl.ResumeLayout(false);
            chatbot_replyPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_replyPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)chatbot_owlPic).EndInit();
            schedule_titlePnl.ResumeLayout(false);
            schedule_titlePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)schedule_titleIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)schedule_dataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel schedule_mainPnl;
        private Button schedule_helpBtn;
        private Button schedule_exportBtn;
        private Button schedule_backBtn;
        private Panel schedule_titlePnl;
        private PictureBox schedule_titleIcon;
        private Label schedule_titleLbl;
        private DataGridView schedule_dataGrid;
        private PictureBox chatbot_owlPic;
        private DataGridViewTextBoxColumn day;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn code;
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
        private Label label1;
    }
}
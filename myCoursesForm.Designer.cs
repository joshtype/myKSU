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
            courses_titleLbl = new Label();
            courses_topPnl = new Panel();
            home_btmPnl = new Panel();
            home_helpBtn = new Button();
            home_exitBtn = new Button();
            home_ksuLink = new Label();
            home_uitsLink = new Label();
            courses_btmPnl = new Panel();
            courses_helpBtn = new Button();
            courses_backBtn = new Button();
            courses_midPnl = new Panel();
            dataGridView1 = new DataGridView();
            courses_topPnl.SuspendLayout();
            home_btmPnl.SuspendLayout();
            courses_btmPnl.SuspendLayout();
            courses_midPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // courses_titleLbl
            // 
            courses_titleLbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            courses_titleLbl.AutoSize = true;
            courses_titleLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courses_titleLbl.Location = new Point(12, 9);
            courses_titleLbl.Name = "courses_titleLbl";
            courses_titleLbl.Size = new Size(165, 41);
            courses_titleLbl.TabIndex = 1;
            courses_titleLbl.Text = "myCourses";
            // 
            // courses_topPnl
            // 
            courses_topPnl.Controls.Add(home_btmPnl);
            courses_topPnl.Controls.Add(courses_titleLbl);
            courses_topPnl.Dock = DockStyle.Top;
            courses_topPnl.Location = new Point(0, 0);
            courses_topPnl.Name = "courses_topPnl";
            courses_topPnl.Size = new Size(521, 58);
            courses_topPnl.TabIndex = 2;
            // 
            // home_btmPnl
            // 
            home_btmPnl.Controls.Add(home_helpBtn);
            home_btmPnl.Controls.Add(home_exitBtn);
            home_btmPnl.Controls.Add(home_ksuLink);
            home_btmPnl.Controls.Add(home_uitsLink);
            home_btmPnl.Location = new Point(0, 642);
            home_btmPnl.Name = "home_btmPnl";
            home_btmPnl.Size = new Size(521, 57);
            home_btmPnl.TabIndex = 15;
            // 
            // home_helpBtn
            // 
            home_helpBtn.BackColor = Color.FromArgb(255, 255, 192);
            home_helpBtn.ForeColor = Color.FromArgb(64, 64, 64);
            home_helpBtn.Location = new Point(464, 16);
            home_helpBtn.Name = "home_helpBtn";
            home_helpBtn.Size = new Size(45, 29);
            home_helpBtn.TabIndex = 12;
            home_helpBtn.Text = "?";
            home_helpBtn.UseVisualStyleBackColor = false;
            // 
            // home_exitBtn
            // 
            home_exitBtn.BackColor = Color.FromArgb(255, 255, 192);
            home_exitBtn.ForeColor = Color.Red;
            home_exitBtn.Location = new Point(12, 16);
            home_exitBtn.Name = "home_exitBtn";
            home_exitBtn.Size = new Size(45, 29);
            home_exitBtn.TabIndex = 13;
            home_exitBtn.Text = "X";
            home_exitBtn.UseVisualStyleBackColor = false;
            // 
            // home_ksuLink
            // 
            home_ksuLink.AutoSize = true;
            home_ksuLink.Location = new Point(160, 5);
            home_ksuLink.Name = "home_ksuLink";
            home_ksuLink.Size = new Size(175, 20);
            home_ksuLink.TabIndex = 7;
            home_ksuLink.Text = "Kennesaw State U. Home";
            // 
            // home_uitsLink
            // 
            home_uitsLink.AutoSize = true;
            home_uitsLink.Location = new Point(160, 25);
            home_uitsLink.Name = "home_uitsLink";
            home_uitsLink.Size = new Size(175, 20);
            home_uitsLink.TabIndex = 8;
            home_uitsLink.Text = "UITS Tech Support Home";
            // 
            // courses_btmPnl
            // 
            courses_btmPnl.Controls.Add(courses_helpBtn);
            courses_btmPnl.Controls.Add(courses_backBtn);
            courses_btmPnl.Dock = DockStyle.Bottom;
            courses_btmPnl.Location = new Point(0, 642);
            courses_btmPnl.Name = "courses_btmPnl";
            courses_btmPnl.Size = new Size(521, 57);
            courses_btmPnl.TabIndex = 15;
            // 
            // courses_helpBtn
            // 
            courses_helpBtn.BackColor = Color.FromArgb(255, 255, 192);
            courses_helpBtn.ForeColor = Color.FromArgb(64, 64, 64);
            courses_helpBtn.Location = new Point(464, 16);
            courses_helpBtn.Name = "courses_helpBtn";
            courses_helpBtn.Size = new Size(45, 29);
            courses_helpBtn.TabIndex = 12;
            courses_helpBtn.Text = "?";
            courses_helpBtn.UseVisualStyleBackColor = false;
            // 
            // courses_backBtn
            // 
            courses_backBtn.BackColor = Color.FromArgb(255, 255, 192);
            courses_backBtn.ForeColor = Color.FromArgb(64, 64, 64);
            courses_backBtn.Location = new Point(12, 16);
            courses_backBtn.Name = "courses_backBtn";
            courses_backBtn.Size = new Size(45, 29);
            courses_backBtn.TabIndex = 13;
            courses_backBtn.Text = "<";
            courses_backBtn.UseVisualStyleBackColor = false;
            // 
            // courses_midPnl
            // 
            courses_midPnl.Controls.Add(dataGridView1);
            courses_midPnl.Dock = DockStyle.Fill;
            courses_midPnl.Location = new Point(0, 58);
            courses_midPnl.Name = "courses_midPnl";
            courses_midPnl.Size = new Size(521, 584);
            courses_midPnl.TabIndex = 16;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            // 
            // myCoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(521, 699);
            Controls.Add(courses_midPnl);
            Controls.Add(courses_btmPnl);
            Controls.Add(courses_topPnl);
            Name = "myCoursesForm";
            Text = "myCoursesForm";
            courses_topPnl.ResumeLayout(false);
            courses_topPnl.PerformLayout();
            home_btmPnl.ResumeLayout(false);
            home_btmPnl.PerformLayout();
            courses_btmPnl.ResumeLayout(false);
            courses_midPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView courses_enrolledCoursesDGV;
        private Label courses_titleLbl;
        private Panel courses_topPnl;
        private Panel home_btmPnl;
        private Button home_helpBtn;
        private Button home_exitBtn;
        private Label home_ksuLink;
        private Label home_uitsLink;
        private Panel courses_btmPnl;
        private Button courses_helpBtn;
        private Button courses_backBtn;
        private Panel courses_midPnl;
        private DataGridView dataGridView1;
    }
}
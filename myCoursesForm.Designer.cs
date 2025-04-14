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
            home_btmPnl = new Panel();
            courses_helpBtn = new Button();
            courses_backBtn = new Button();
            home_ksuLink = new Label();
            home_uitsLink = new Label();
            courses_midPnl = new Panel();
            courses_topPnl = new Panel();
            courses_titleLbl = new Label();
            home_btmPnl.SuspendLayout();
            courses_topPnl.SuspendLayout();
            SuspendLayout();
            // 
            // home_btmPnl
            // 
            home_btmPnl.Controls.Add(courses_helpBtn);
            home_btmPnl.Controls.Add(courses_backBtn);
            home_btmPnl.Controls.Add(home_ksuLink);
            home_btmPnl.Controls.Add(home_uitsLink);
            home_btmPnl.Dock = DockStyle.Bottom;
            home_btmPnl.Location = new Point(0, 642);
            home_btmPnl.Name = "home_btmPnl";
            home_btmPnl.Size = new Size(521, 57);
            home_btmPnl.TabIndex = 19;
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
            courses_helpBtn.Click += this.courses_helpBtn_Click;
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
            courses_backBtn.Click += courses_backBtn_Click;
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
            // courses_midPnl
            // 
            courses_midPnl.Dock = DockStyle.Fill;
            courses_midPnl.Location = new Point(0, 56);
            courses_midPnl.Name = "courses_midPnl";
            courses_midPnl.Size = new Size(521, 643);
            courses_midPnl.TabIndex = 18;
            // 
            // courses_topPnl
            // 
            courses_topPnl.Controls.Add(courses_titleLbl);
            courses_topPnl.Dock = DockStyle.Top;
            courses_topPnl.Location = new Point(0, 0);
            courses_topPnl.Name = "courses_topPnl";
            courses_topPnl.Size = new Size(521, 56);
            courses_topPnl.TabIndex = 17;
            // 
            // courses_titleLbl
            // 
            courses_titleLbl.AutoSize = true;
            courses_titleLbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courses_titleLbl.Location = new Point(12, 9);
            courses_titleLbl.Name = "courses_titleLbl";
            courses_titleLbl.Size = new Size(153, 38);
            courses_titleLbl.TabIndex = 0;
            courses_titleLbl.Text = "myCourses";
            // 
            // myCoursesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(521, 699);
            Controls.Add(home_btmPnl);
            Controls.Add(courses_midPnl);
            Controls.Add(courses_topPnl);
            Name = "myCoursesForm";
            Text = "myCourses";
            home_btmPnl.ResumeLayout(false);
            home_btmPnl.PerformLayout();
            courses_topPnl.ResumeLayout(false);
            courses_topPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel home_btmPnl;
        private Button courses_helpBtn;
        private Button courses_backBtn;
        private Label home_ksuLink;
        private Label home_uitsLink;
        private Panel courses_midPnl;
        private Panel courses_topPnl;
        private Label courses_titleLbl;
    }
}
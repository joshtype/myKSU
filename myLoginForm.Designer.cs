namespace myKSU_v3
{
    public partial class myLoginForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myLoginForm));
            login_logoPic = new PictureBox();
            login_picLbl = new Label();
            login_emailTxt = new TextBox();
            login_passTxt = new TextBox();
            login_idTxt = new TextBox();
            login_emailLbl = new Label();
            login_passLbl = new Label();
            login_idLbl = new Label();
            login_authenticateBtn = new Button();
            login_helpBtn = new Button();
            login_footerLbl = new Label();
            login_exitBtn = new Button();
            login_errorLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)login_logoPic).BeginInit();
            SuspendLayout();
            // 
            // login_logoPic
            // 
            login_logoPic.Dock = DockStyle.Top;
            login_logoPic.Image = (Image)resources.GetObject("login_logoPic.Image");
            login_logoPic.Location = new Point(0, 0);
            login_logoPic.Name = "login_logoPic";
            login_logoPic.Size = new Size(521, 122);
            login_logoPic.TabIndex = 0;
            login_logoPic.TabStop = false;
            // 
            // login_picLbl
            // 
            login_picLbl.AutoSize = true;
            login_picLbl.Location = new Point(112, 125);
            login_picLbl.Name = "login_picLbl";
            login_picLbl.Size = new Size(228, 20);
            login_picLbl.TabIndex = 1;
            login_picLbl.Text = "Your education at your fingertips.";
            // 
            // login_emailTxt
            // 
            login_emailTxt.Font = new Font("Segoe UI", 12F);
            login_emailTxt.Location = new Point(188, 270);
            login_emailTxt.Name = "login_emailTxt";
            login_emailTxt.Size = new Size(198, 34);
            login_emailTxt.TabIndex = 2;
            // 
            // login_passTxt
            // 
            login_passTxt.Font = new Font("Segoe UI", 12F);
            login_passTxt.Location = new Point(188, 330);
            login_passTxt.Name = "login_passTxt";
            login_passTxt.Size = new Size(198, 34);
            login_passTxt.TabIndex = 3;
            // 
            // login_idTxt
            // 
            login_idTxt.Font = new Font("Segoe UI", 12F);
            login_idTxt.Location = new Point(188, 390);
            login_idTxt.Name = "login_idTxt";
            login_idTxt.Size = new Size(198, 34);
            login_idTxt.TabIndex = 4;
            // 
            // login_emailLbl
            // 
            login_emailLbl.AutoSize = true;
            login_emailLbl.Font = new Font("Segoe UI", 12F);
            login_emailLbl.Location = new Point(77, 270);
            login_emailLbl.Name = "login_emailLbl";
            login_emailLbl.Size = new Size(105, 28);
            login_emailLbl.TabIndex = 5;
            login_emailLbl.Text = "KSU Email:";
            // 
            // login_passLbl
            // 
            login_passLbl.AutoSize = true;
            login_passLbl.Font = new Font("Segoe UI", 12F);
            login_passLbl.Location = new Point(43, 330);
            login_passLbl.Name = "login_passLbl";
            login_passLbl.Size = new Size(139, 28);
            login_passLbl.TabIndex = 6;
            login_passLbl.Text = "KSU Password:";
            // 
            // login_idLbl
            // 
            login_idLbl.AutoSize = true;
            login_idLbl.Font = new Font("Segoe UI", 12F);
            login_idLbl.Location = new Point(95, 390);
            login_idLbl.Name = "login_idLbl";
            login_idLbl.Size = new Size(77, 28);
            login_idLbl.TabIndex = 7;
            login_idLbl.Text = "KSU ID:";
            // 
            // login_authenticateBtn
            // 
            login_authenticateBtn.BackColor = Color.FromArgb(255, 255, 192);
            login_authenticateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_authenticateBtn.Location = new Point(188, 443);
            login_authenticateBtn.Name = "login_authenticateBtn";
            login_authenticateBtn.Size = new Size(137, 44);
            login_authenticateBtn.TabIndex = 8;
            login_authenticateBtn.Text = "Authenticate";
            login_authenticateBtn.UseVisualStyleBackColor = false;
            login_authenticateBtn.Click += login_authenticateBtn_Click;
            // 
            // login_helpBtn
            // 
            login_helpBtn.BackColor = Color.FromArgb(255, 255, 192);
            login_helpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_helpBtn.Location = new Point(340, 443);
            login_helpBtn.Name = "login_helpBtn";
            login_helpBtn.Size = new Size(46, 44);
            login_helpBtn.TabIndex = 9;
            login_helpBtn.Text = "?";
            login_helpBtn.UseVisualStyleBackColor = false;
            login_helpBtn.Click += login_helpBtn_Click;
            // 
            // login_footerLbl
            // 
            login_footerLbl.AutoSize = true;
            login_footerLbl.Location = new Point(12, 670);
            login_footerLbl.Name = "login_footerLbl";
            login_footerLbl.Size = new Size(182, 20);
            login_footerLbl.TabIndex = 10;
            login_footerLbl.Text = "(c) 2025 Group 8 Software";
            // 
            // login_exitBtn
            // 
            login_exitBtn.BackColor = Color.FromArgb(255, 255, 192);
            login_exitBtn.ForeColor = Color.Red;
            login_exitBtn.Location = new Point(447, 661);
            login_exitBtn.Name = "login_exitBtn";
            login_exitBtn.Size = new Size(62, 29);
            login_exitBtn.TabIndex = 11;
            login_exitBtn.Text = "EXIT";
            login_exitBtn.UseVisualStyleBackColor = false;
            // 
            // login_errorLbl
            // 
            login_errorLbl.AutoSize = true;
            login_errorLbl.ForeColor = Color.Red;
            login_errorLbl.Location = new Point(42, 500);
            login_errorLbl.Name = "login_errorLbl";
            login_errorLbl.Size = new Size(467, 20);
            login_errorLbl.TabIndex = 12;
            login_errorLbl.Text = "Invalid credentials. Use the help button to view prototype credentials.";
            login_errorLbl.Visible = false;
            // 
            // myLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(521, 699);
            Controls.Add(login_errorLbl);
            Controls.Add(login_exitBtn);
            Controls.Add(login_footerLbl);
            Controls.Add(login_helpBtn);
            Controls.Add(login_authenticateBtn);
            Controls.Add(login_idLbl);
            Controls.Add(login_passLbl);
            Controls.Add(login_emailLbl);
            Controls.Add(login_idTxt);
            Controls.Add(login_passTxt);
            Controls.Add(login_emailTxt);
            Controls.Add(login_picLbl);
            Controls.Add(login_logoPic);
            Name = "myLoginForm";
            Text = "myKSU Login";
            ((System.ComponentModel.ISupportInitialize)login_logoPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox login_logoPic;
        private Label login_picLbl;
        private TextBox login_emailTxt;
        private TextBox login_passTxt;
        private TextBox login_idTxt;
        private Label login_emailLbl;
        private Label login_passLbl;
        private Label login_idLbl;
        private Button login_authenticateBtn;
        private Button login_helpBtn;
        private Label login_footerLbl;
        private Button login_exitBtn;
        private Label login_errorLbl;
    }
}

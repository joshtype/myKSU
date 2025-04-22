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
            login_credentialsPnl = new Panel();
            login_logoPic = new PictureBox();
            login_prototypeHelpLbl = new Label();
            home_ksuLink = new Label();
            home_uitsLink = new Label();
            login_credentialsPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)login_logoPic).BeginInit();
            SuspendLayout();
            // 
            // login_emailTxt
            // 
            login_emailTxt.Anchor = AnchorStyles.None;
            login_emailTxt.Font = new Font("Segoe UI", 12F);
            login_emailTxt.Location = new Point(166, 148);
            login_emailTxt.Name = "login_emailTxt";
            login_emailTxt.PlaceholderText = "'email'";
            login_emailTxt.Size = new Size(198, 34);
            login_emailTxt.TabIndex = 2;
            // 
            // login_passTxt
            // 
            login_passTxt.Anchor = AnchorStyles.None;
            login_passTxt.Font = new Font("Segoe UI", 12F);
            login_passTxt.Location = new Point(166, 188);
            login_passTxt.Name = "login_passTxt";
            login_passTxt.PasswordChar = '*';
            login_passTxt.PlaceholderText = "'pass'";
            login_passTxt.Size = new Size(198, 34);
            login_passTxt.TabIndex = 3;
            // 
            // login_idTxt
            // 
            login_idTxt.Anchor = AnchorStyles.None;
            login_idTxt.Font = new Font("Segoe UI", 12F);
            login_idTxt.Location = new Point(166, 228);
            login_idTxt.Name = "login_idTxt";
            login_idTxt.PlaceholderText = "'1'";
            login_idTxt.Size = new Size(198, 34);
            login_idTxt.TabIndex = 4;
            // 
            // login_emailLbl
            // 
            login_emailLbl.Anchor = AnchorStyles.None;
            login_emailLbl.AutoSize = true;
            login_emailLbl.Font = new Font("Segoe UI", 12F);
            login_emailLbl.Location = new Point(55, 154);
            login_emailLbl.Name = "login_emailLbl";
            login_emailLbl.Size = new Size(105, 28);
            login_emailLbl.TabIndex = 5;
            login_emailLbl.Text = "KSU Email:";
            // 
            // login_passLbl
            // 
            login_passLbl.Anchor = AnchorStyles.None;
            login_passLbl.AutoSize = true;
            login_passLbl.Font = new Font("Segoe UI", 12F);
            login_passLbl.Location = new Point(21, 194);
            login_passLbl.Name = "login_passLbl";
            login_passLbl.Size = new Size(139, 28);
            login_passLbl.TabIndex = 6;
            login_passLbl.Text = "KSU Password:";
            // 
            // login_idLbl
            // 
            login_idLbl.Anchor = AnchorStyles.None;
            login_idLbl.AutoSize = true;
            login_idLbl.Font = new Font("Segoe UI", 12F);
            login_idLbl.Location = new Point(83, 234);
            login_idLbl.Name = "login_idLbl";
            login_idLbl.Size = new Size(77, 28);
            login_idLbl.TabIndex = 7;
            login_idLbl.Text = "KSU ID:";
            // 
            // login_authenticateBtn
            // 
            login_authenticateBtn.Anchor = AnchorStyles.None;
            login_authenticateBtn.BackColor = Color.Gold;
            login_authenticateBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_authenticateBtn.Location = new Point(166, 268);
            login_authenticateBtn.Name = "login_authenticateBtn";
            login_authenticateBtn.Size = new Size(137, 44);
            login_authenticateBtn.TabIndex = 8;
            login_authenticateBtn.Text = "Authenticate";
            login_authenticateBtn.UseVisualStyleBackColor = false;
            login_authenticateBtn.Click += login_authenticateBtn_Click;
            // 
            // login_helpBtn
            // 
            login_helpBtn.Anchor = AnchorStyles.None;
            login_helpBtn.BackColor = Color.Gold;
            login_helpBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_helpBtn.ForeColor = Color.Black;
            login_helpBtn.Location = new Point(318, 268);
            login_helpBtn.Name = "login_helpBtn";
            login_helpBtn.Size = new Size(46, 44);
            login_helpBtn.TabIndex = 9;
            login_helpBtn.Text = "?";
            login_helpBtn.UseVisualStyleBackColor = false;
            login_helpBtn.Click += login_helpBtn_Click;
            // 
            // login_footerLbl
            // 
            login_footerLbl.Anchor = AnchorStyles.None;
            login_footerLbl.AutoSize = true;
            login_footerLbl.BackColor = Color.WhiteSmoke;
            login_footerLbl.ForeColor = Color.FromArgb(64, 64, 64);
            login_footerLbl.Location = new Point(199, 670);
            login_footerLbl.Name = "login_footerLbl";
            login_footerLbl.Size = new Size(119, 20);
            login_footerLbl.TabIndex = 10;
            login_footerLbl.Text = "(c) 2025 Group 8";
            // 
            // login_exitBtn
            // 
            login_exitBtn.Anchor = AnchorStyles.None;
            login_exitBtn.BackColor = Color.Gold;
            login_exitBtn.ForeColor = Color.FromArgb(64, 64, 64);
            login_exitBtn.Location = new Point(464, 12);
            login_exitBtn.Name = "login_exitBtn";
            login_exitBtn.Size = new Size(45, 37);
            login_exitBtn.TabIndex = 11;
            login_exitBtn.Text = "X";
            login_exitBtn.UseVisualStyleBackColor = false;
            login_exitBtn.Click += login_exitBtn_Click;
            // 
            // login_errorLbl
            // 
            login_errorLbl.Anchor = AnchorStyles.None;
            login_errorLbl.AutoSize = true;
            login_errorLbl.ForeColor = Color.Red;
            login_errorLbl.Location = new Point(71, 315);
            login_errorLbl.Name = "login_errorLbl";
            login_errorLbl.Size = new Size(293, 20);
            login_errorLbl.TabIndex = 12;
            login_errorLbl.Text = "Invalid email, password, or KSU ID entered.";
            login_errorLbl.Visible = false;
            // 
            // login_credentialsPnl
            // 
            login_credentialsPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            login_credentialsPnl.BorderStyle = BorderStyle.FixedSingle;
            login_credentialsPnl.Controls.Add(login_logoPic);
            login_credentialsPnl.Controls.Add(login_prototypeHelpLbl);
            login_credentialsPnl.Controls.Add(login_emailTxt);
            login_credentialsPnl.Controls.Add(login_errorLbl);
            login_credentialsPnl.Controls.Add(login_passTxt);
            login_credentialsPnl.Controls.Add(login_helpBtn);
            login_credentialsPnl.Controls.Add(login_idTxt);
            login_credentialsPnl.Controls.Add(login_emailLbl);
            login_credentialsPnl.Controls.Add(login_idLbl);
            login_credentialsPnl.Controls.Add(login_authenticateBtn);
            login_credentialsPnl.Controls.Add(login_passLbl);
            login_credentialsPnl.Location = new Point(41, 150);
            login_credentialsPnl.Name = "login_credentialsPnl";
            login_credentialsPnl.Size = new Size(438, 357);
            login_credentialsPnl.TabIndex = 13;
            // 
            // login_logoPic
            // 
            login_logoPic.Anchor = AnchorStyles.None;
            login_logoPic.BorderStyle = BorderStyle.FixedSingle;
            login_logoPic.Image = (Image)resources.GetObject("login_logoPic.Image");
            login_logoPic.Location = new Point(55, 13);
            login_logoPic.Name = "login_logoPic";
            login_logoPic.Size = new Size(309, 129);
            login_logoPic.SizeMode = PictureBoxSizeMode.StretchImage;
            login_logoPic.TabIndex = 14;
            login_logoPic.TabStop = false;
            // 
            // login_prototypeHelpLbl
            // 
            login_prototypeHelpLbl.Anchor = AnchorStyles.None;
            login_prototypeHelpLbl.AutoSize = true;
            login_prototypeHelpLbl.ForeColor = Color.FromArgb(255, 128, 0);
            login_prototypeHelpLbl.Location = new Point(83, 335);
            login_prototypeHelpLbl.Name = "login_prototypeHelpLbl";
            login_prototypeHelpLbl.Size = new Size(264, 20);
            login_prototypeHelpLbl.TabIndex = 13;
            login_prototypeHelpLbl.Text = "Prototype: use ? button for credentials.";
            login_prototypeHelpLbl.Visible = false;
            // 
            // home_ksuLink
            // 
            home_ksuLink.AutoSize = true;
            home_ksuLink.BackColor = Color.WhiteSmoke;
            home_ksuLink.Location = new Point(41, 510);
            home_ksuLink.Name = "home_ksuLink";
            home_ksuLink.Size = new Size(115, 20);
            home_ksuLink.TabIndex = 27;
            home_ksuLink.Text = "KSU Homepage";
            // 
            // home_uitsLink
            // 
            home_uitsLink.AutoSize = true;
            home_uitsLink.BackColor = Color.WhiteSmoke;
            home_uitsLink.Location = new Point(349, 510);
            home_uitsLink.Name = "home_uitsLink";
            home_uitsLink.Size = new Size(130, 20);
            home_uitsLink.TabIndex = 28;
            home_uitsLink.Text = "UITS Tech Support";
            // 
            // myLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(521, 699);
            Controls.Add(home_ksuLink);
            Controls.Add(home_uitsLink);
            Controls.Add(login_credentialsPnl);
            Controls.Add(login_exitBtn);
            Controls.Add(login_footerLbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(539, 746);
            MinimumSize = new Size(539, 746);
            Name = "myLoginForm";
            Text = "[ myLogin ]";
            login_credentialsPnl.ResumeLayout(false);
            login_credentialsPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)login_logoPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Panel login_credentialsPnl;
        private Label login_prototypeHelpLbl;
        private PictureBox login_logoPic;
        private Label home_ksuLink;
        private Label home_uitsLink;
    }
}

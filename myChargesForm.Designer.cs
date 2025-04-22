namespace myKSU_v3
{
    partial class myChargesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(myChargesForm));
            charges_mainPnl = new Panel();
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
            panel1 = new Panel();
            label1 = new Label();
            charges_paidBtn = new Button();
            charges_unpaidBtn = new Button();
            charges_methodPnl = new Panel();
            bank_routingLbl = new Label();
            bank_routingText = new TextBox();
            charges_payBtn = new Button();
            bank_acctLbl = new Label();
            bank_acctText = new TextBox();
            cc_yyyyText = new TextBox();
            cc_expLbl = new Label();
            cc_nameLbl = new Label();
            cc_numLbl = new Label();
            cc_mmText = new TextBox();
            cc_numText = new TextBox();
            cc_nameText = new TextBox();
            details_payMethodMenu = new ComboBox();
            details_payMethodLbl = new Label();
            charges_helpBtn = new Button();
            charges_headerPnl = new Panel();
            charges_acctNumLbl = new Label();
            charges_semesterLbl = new Label();
            charges_backBtn = new Button();
            registration_titlePnl = new Panel();
            charges_titleIcon = new PictureBox();
            charges_titleLbl = new Label();
            charges_unpaidCharges = new Panel();
            charges_totalUnpaid = new Label();
            charges_chargesDataGrid = new DataGridView();
            charges_totalPaid = new Label();
            charges_mainPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_owlPic).BeginInit();
            chatbot_mainPnl.SuspendLayout();
            chatbot_topPnl.SuspendLayout();
            chatbot_replyPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_replyPic).BeginInit();
            panel1.SuspendLayout();
            charges_methodPnl.SuspendLayout();
            charges_headerPnl.SuspendLayout();
            registration_titlePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)charges_titleIcon).BeginInit();
            charges_unpaidCharges.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)charges_chargesDataGrid).BeginInit();
            SuspendLayout();
            // 
            // charges_mainPnl
            // 
            charges_mainPnl.BackColor = Color.White;
            charges_mainPnl.BackgroundImage = (Image)resources.GetObject("charges_mainPnl.BackgroundImage");
            charges_mainPnl.Controls.Add(chatbot_owlPic);
            charges_mainPnl.Controls.Add(chatbot_mainPnl);
            charges_mainPnl.Controls.Add(panel1);
            charges_mainPnl.Controls.Add(charges_methodPnl);
            charges_mainPnl.Controls.Add(charges_helpBtn);
            charges_mainPnl.Controls.Add(charges_headerPnl);
            charges_mainPnl.Controls.Add(charges_backBtn);
            charges_mainPnl.Controls.Add(registration_titlePnl);
            charges_mainPnl.Controls.Add(charges_unpaidCharges);
            charges_mainPnl.Dock = DockStyle.Fill;
            charges_mainPnl.Location = new Point(0, 0);
            charges_mainPnl.Name = "charges_mainPnl";
            charges_mainPnl.Size = new Size(521, 699);
            charges_mainPnl.TabIndex = 28;
            // 
            // chatbot_owlPic
            // 
            chatbot_owlPic.BackColor = Color.Transparent;
            chatbot_owlPic.Image = (Image)resources.GetObject("chatbot_owlPic.Image");
            chatbot_owlPic.Location = new Point(441, 637);
            chatbot_owlPic.Name = "chatbot_owlPic";
            chatbot_owlPic.Size = new Size(68, 62);
            chatbot_owlPic.SizeMode = PictureBoxSizeMode.StretchImage;
            chatbot_owlPic.TabIndex = 45;
            chatbot_owlPic.TabStop = false;
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
            chatbot_mainPnl.TabIndex = 44;
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
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(charges_paidBtn);
            panel1.Controls.Add(charges_unpaidBtn);
            panel1.Location = new Point(238, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 63);
            panel1.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 5);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 35;
            label1.Text = "Select to view:";
            // 
            // charges_paidBtn
            // 
            charges_paidBtn.BackColor = Color.Gold;
            charges_paidBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            charges_paidBtn.ForeColor = Color.Black;
            charges_paidBtn.Location = new Point(3, 25);
            charges_paidBtn.Name = "charges_paidBtn";
            charges_paidBtn.Size = new Size(115, 31);
            charges_paidBtn.TabIndex = 33;
            charges_paidBtn.Text = "Paid Charges";
            charges_paidBtn.UseVisualStyleBackColor = false;
            charges_paidBtn.Click += charges_paidBtn_Click;
            // 
            // charges_unpaidBtn
            // 
            charges_unpaidBtn.BackColor = Color.Gold;
            charges_unpaidBtn.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            charges_unpaidBtn.ForeColor = Color.Black;
            charges_unpaidBtn.Location = new Point(124, 25);
            charges_unpaidBtn.Name = "charges_unpaidBtn";
            charges_unpaidBtn.Size = new Size(123, 31);
            charges_unpaidBtn.TabIndex = 34;
            charges_unpaidBtn.Text = "Unpaid Charges";
            charges_unpaidBtn.UseVisualStyleBackColor = false;
            charges_unpaidBtn.Click += charges_unpaidBtn_Click;
            // 
            // charges_methodPnl
            // 
            charges_methodPnl.BorderStyle = BorderStyle.FixedSingle;
            charges_methodPnl.Controls.Add(bank_routingLbl);
            charges_methodPnl.Controls.Add(bank_routingText);
            charges_methodPnl.Controls.Add(charges_payBtn);
            charges_methodPnl.Controls.Add(bank_acctLbl);
            charges_methodPnl.Controls.Add(bank_acctText);
            charges_methodPnl.Controls.Add(cc_yyyyText);
            charges_methodPnl.Controls.Add(cc_expLbl);
            charges_methodPnl.Controls.Add(cc_nameLbl);
            charges_methodPnl.Controls.Add(cc_numLbl);
            charges_methodPnl.Controls.Add(cc_mmText);
            charges_methodPnl.Controls.Add(cc_numText);
            charges_methodPnl.Controls.Add(cc_nameText);
            charges_methodPnl.Controls.Add(details_payMethodMenu);
            charges_methodPnl.Controls.Add(details_payMethodLbl);
            charges_methodPnl.Location = new Point(14, 400);
            charges_methodPnl.Name = "charges_methodPnl";
            charges_methodPnl.Size = new Size(486, 231);
            charges_methodPnl.TabIndex = 42;
            // 
            // bank_routingLbl
            // 
            bank_routingLbl.AutoSize = true;
            bank_routingLbl.Location = new Point(271, 124);
            bank_routingLbl.Name = "bank_routingLbl";
            bank_routingLbl.Size = new Size(77, 20);
            bank_routingLbl.TabIndex = 52;
            bank_routingLbl.Text = "Routing #:";
            // 
            // bank_routingText
            // 
            bank_routingText.BackColor = Color.WhiteSmoke;
            bank_routingText.Location = new Point(271, 147);
            bank_routingText.Name = "bank_routingText";
            bank_routingText.PlaceholderText = "1234-1234-1234-1234";
            bank_routingText.ReadOnly = true;
            bank_routingText.Size = new Size(186, 27);
            bank_routingText.TabIndex = 51;
            // 
            // charges_payBtn
            // 
            charges_payBtn.BackColor = Color.Gold;
            charges_payBtn.Font = new Font("Segoe UI", 10.2F);
            charges_payBtn.ForeColor = Color.Black;
            charges_payBtn.Location = new Point(271, 180);
            charges_payBtn.Name = "charges_payBtn";
            charges_payBtn.Size = new Size(186, 36);
            charges_payBtn.TabIndex = 23;
            charges_payBtn.Text = "Submit Payment";
            charges_payBtn.UseVisualStyleBackColor = false;
            charges_payBtn.Click += charges_payBtn_Click;
            // 
            // bank_acctLbl
            // 
            bank_acctLbl.AutoSize = true;
            bank_acctLbl.Location = new Point(271, 64);
            bank_acctLbl.Name = "bank_acctLbl";
            bank_acctLbl.Size = new Size(115, 20);
            bank_acctLbl.TabIndex = 50;
            bank_acctLbl.Text = "Bank Account #:";
            // 
            // bank_acctText
            // 
            bank_acctText.BackColor = Color.WhiteSmoke;
            bank_acctText.Location = new Point(271, 87);
            bank_acctText.Name = "bank_acctText";
            bank_acctText.PlaceholderText = "1234-1234-1234-1234";
            bank_acctText.ReadOnly = true;
            bank_acctText.Size = new Size(186, 27);
            bank_acctText.TabIndex = 49;
            // 
            // cc_yyyyText
            // 
            cc_yyyyText.BackColor = Color.WhiteSmoke;
            cc_yyyyText.Location = new Point(90, 194);
            cc_yyyyText.Name = "cc_yyyyText";
            cc_yyyyText.PlaceholderText = "yyyy";
            cc_yyyyText.ReadOnly = true;
            cc_yyyyText.Size = new Size(127, 27);
            cc_yyyyText.TabIndex = 48;
            // 
            // cc_expLbl
            // 
            cc_expLbl.AutoSize = true;
            cc_expLbl.Location = new Point(31, 171);
            cc_expLbl.Name = "cc_expLbl";
            cc_expLbl.Size = new Size(79, 20);
            cc_expLbl.TabIndex = 47;
            cc_expLbl.Text = "Expiration:";
            // 
            // cc_nameLbl
            // 
            cc_nameLbl.AutoSize = true;
            cc_nameLbl.Location = new Point(31, 117);
            cc_nameLbl.Name = "cc_nameLbl";
            cc_nameLbl.Size = new Size(130, 20);
            cc_nameLbl.TabIndex = 46;
            cc_nameLbl.Text = "Cardholder Name:";
            // 
            // cc_numLbl
            // 
            cc_numLbl.AutoSize = true;
            cc_numLbl.Location = new Point(31, 64);
            cc_numLbl.Name = "cc_numLbl";
            cc_numLbl.Size = new Size(101, 20);
            cc_numLbl.TabIndex = 45;
            cc_numLbl.Text = "Card Number:";
            // 
            // cc_mmText
            // 
            cc_mmText.BackColor = Color.WhiteSmoke;
            cc_mmText.Location = new Point(31, 194);
            cc_mmText.Name = "cc_mmText";
            cc_mmText.PlaceholderText = "mm";
            cc_mmText.ReadOnly = true;
            cc_mmText.Size = new Size(53, 27);
            cc_mmText.TabIndex = 44;
            // 
            // cc_numText
            // 
            cc_numText.BackColor = Color.WhiteSmoke;
            cc_numText.Location = new Point(31, 87);
            cc_numText.Name = "cc_numText";
            cc_numText.PlaceholderText = "1234-1234-1234-1234";
            cc_numText.ReadOnly = true;
            cc_numText.Size = new Size(186, 27);
            cc_numText.TabIndex = 43;
            // 
            // cc_nameText
            // 
            cc_nameText.BackColor = Color.WhiteSmoke;
            cc_nameText.Location = new Point(31, 140);
            cc_nameText.Name = "cc_nameText";
            cc_nameText.PlaceholderText = "Sama S. Tudent";
            cc_nameText.ReadOnly = true;
            cc_nameText.Size = new Size(186, 27);
            cc_nameText.TabIndex = 42;
            // 
            // details_payMethodMenu
            // 
            details_payMethodMenu.FormattingEnabled = true;
            details_payMethodMenu.Items.AddRange(new object[] { "Credit Card", "Bank Transfer" });
            details_payMethodMenu.Location = new Point(148, 12);
            details_payMethodMenu.Name = "details_payMethodMenu";
            details_payMethodMenu.Size = new Size(186, 28);
            details_payMethodMenu.TabIndex = 40;
            // 
            // details_payMethodLbl
            // 
            details_payMethodLbl.AutoSize = true;
            details_payMethodLbl.Location = new Point(78, 20);
            details_payMethodLbl.Name = "details_payMethodLbl";
            details_payMethodLbl.Size = new Size(64, 20);
            details_payMethodLbl.TabIndex = 41;
            details_payMethodLbl.Text = "Method:";
            // 
            // charges_helpBtn
            // 
            charges_helpBtn.BackColor = Color.Gold;
            charges_helpBtn.Font = new Font("Segoe UI", 10.2F);
            charges_helpBtn.ForeColor = Color.Black;
            charges_helpBtn.Location = new Point(14, 637);
            charges_helpBtn.Name = "charges_helpBtn";
            charges_helpBtn.Size = new Size(45, 37);
            charges_helpBtn.TabIndex = 12;
            charges_helpBtn.Text = "?";
            charges_helpBtn.UseVisualStyleBackColor = false;
            charges_helpBtn.Click += charges_helpBtn_Click;
            // 
            // charges_headerPnl
            // 
            charges_headerPnl.BorderStyle = BorderStyle.FixedSingle;
            charges_headerPnl.Controls.Add(charges_acctNumLbl);
            charges_headerPnl.Controls.Add(charges_semesterLbl);
            charges_headerPnl.Location = new Point(14, 64);
            charges_headerPnl.Name = "charges_headerPnl";
            charges_headerPnl.Size = new Size(225, 63);
            charges_headerPnl.TabIndex = 40;
            // 
            // charges_acctNumLbl
            // 
            charges_acctNumLbl.AutoSize = true;
            charges_acctNumLbl.Location = new Point(12, 36);
            charges_acctNumLbl.Name = "charges_acctNumLbl";
            charges_acctNumLbl.Size = new Size(66, 20);
            charges_acctNumLbl.TabIndex = 40;
            charges_acctNumLbl.Text = "Account:";
            // 
            // charges_semesterLbl
            // 
            charges_semesterLbl.AutoSize = true;
            charges_semesterLbl.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            charges_semesterLbl.Location = new Point(5, 5);
            charges_semesterLbl.Name = "charges_semesterLbl";
            charges_semesterLbl.Size = new Size(73, 20);
            charges_semesterLbl.TabIndex = 39;
            charges_semesterLbl.Text = "Semester:";
            // 
            // charges_backBtn
            // 
            charges_backBtn.BackColor = Color.Gold;
            charges_backBtn.BackgroundImage = (Image)resources.GetObject("charges_backBtn.BackgroundImage");
            charges_backBtn.BackgroundImageLayout = ImageLayout.Stretch;
            charges_backBtn.ForeColor = Color.FromArgb(64, 64, 64);
            charges_backBtn.Location = new Point(464, 12);
            charges_backBtn.Name = "charges_backBtn";
            charges_backBtn.Size = new Size(45, 37);
            charges_backBtn.TabIndex = 13;
            charges_backBtn.UseVisualStyleBackColor = false;
            charges_backBtn.Click += charges_backBtn_Click;
            // 
            // registration_titlePnl
            // 
            registration_titlePnl.BackColor = Color.White;
            registration_titlePnl.BorderStyle = BorderStyle.FixedSingle;
            registration_titlePnl.Controls.Add(charges_titleIcon);
            registration_titlePnl.Controls.Add(charges_titleLbl);
            registration_titlePnl.Location = new Point(14, 27);
            registration_titlePnl.Name = "registration_titlePnl";
            registration_titlePnl.Size = new Size(200, 40);
            registration_titlePnl.TabIndex = 32;
            // 
            // charges_titleIcon
            // 
            charges_titleIcon.Image = (Image)resources.GetObject("charges_titleIcon.Image");
            charges_titleIcon.Location = new Point(2, 3);
            charges_titleIcon.Name = "charges_titleIcon";
            charges_titleIcon.Size = new Size(44, 34);
            charges_titleIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            charges_titleIcon.TabIndex = 23;
            charges_titleIcon.TabStop = false;
            // 
            // charges_titleLbl
            // 
            charges_titleLbl.AutoSize = true;
            charges_titleLbl.Font = new Font("Century Schoolbook", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            charges_titleLbl.ForeColor = Color.Gold;
            charges_titleLbl.Location = new Point(52, 6);
            charges_titleLbl.Name = "charges_titleLbl";
            charges_titleLbl.Size = new Size(147, 27);
            charges_titleLbl.TabIndex = 0;
            charges_titleLbl.Text = "myCharges";
            // 
            // charges_unpaidCharges
            // 
            charges_unpaidCharges.BorderStyle = BorderStyle.FixedSingle;
            charges_unpaidCharges.Controls.Add(charges_totalUnpaid);
            charges_unpaidCharges.Controls.Add(charges_chargesDataGrid);
            charges_unpaidCharges.Controls.Add(charges_totalPaid);
            charges_unpaidCharges.Location = new Point(14, 133);
            charges_unpaidCharges.Name = "charges_unpaidCharges";
            charges_unpaidCharges.Size = new Size(486, 261);
            charges_unpaidCharges.TabIndex = 29;
            // 
            // charges_totalUnpaid
            // 
            charges_totalUnpaid.AutoSize = true;
            charges_totalUnpaid.Location = new Point(16, 239);
            charges_totalUnpaid.Name = "charges_totalUnpaid";
            charges_totalUnpaid.Size = new Size(77, 20);
            charges_totalUnpaid.TabIndex = 42;
            charges_totalUnpaid.Text = "Paid Total:";
            // 
            // charges_chargesDataGrid
            // 
            charges_chargesDataGrid.AllowUserToAddRows = false;
            charges_chargesDataGrid.AllowUserToDeleteRows = false;
            charges_chargesDataGrid.BackgroundColor = Color.White;
            charges_chargesDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            charges_chargesDataGrid.Location = new Point(16, 13);
            charges_chargesDataGrid.Name = "charges_chargesDataGrid";
            charges_chargesDataGrid.RowHeadersWidth = 51;
            charges_chargesDataGrid.Size = new Size(455, 223);
            charges_chargesDataGrid.TabIndex = 0;
            // 
            // charges_totalPaid
            // 
            charges_totalPaid.AutoSize = true;
            charges_totalPaid.Location = new Point(289, 239);
            charges_totalPaid.Name = "charges_totalPaid";
            charges_totalPaid.Size = new Size(97, 20);
            charges_totalPaid.TabIndex = 41;
            charges_totalPaid.Text = "Unpaid Total:";
            // 
            // myChargesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 699);
            Controls.Add(charges_mainPnl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(539, 746);
            MinimumSize = new Size(539, 746);
            Name = "myChargesForm";
            Text = "[ myCharges ]";
            charges_mainPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chatbot_owlPic).EndInit();
            chatbot_mainPnl.ResumeLayout(false);
            chatbot_mainPnl.PerformLayout();
            chatbot_topPnl.ResumeLayout(false);
            chatbot_topPnl.PerformLayout();
            chatbot_replyPnl.ResumeLayout(false);
            chatbot_replyPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chatbot_replyPic).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            charges_methodPnl.ResumeLayout(false);
            charges_methodPnl.PerformLayout();
            charges_headerPnl.ResumeLayout(false);
            charges_headerPnl.PerformLayout();
            registration_titlePnl.ResumeLayout(false);
            registration_titlePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)charges_titleIcon).EndInit();
            charges_unpaidCharges.ResumeLayout(false);
            charges_unpaidCharges.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)charges_chargesDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel charges_mainPnl;
        private Button charges_helpBtn;
        private Panel results_titlePnl;
        private PictureBox results_titleIcon;
        private Label results_titleLbl;
        private Button registration_resetBtn;
        private Button charges_backBtn;
        private DataGridView registration_catalogDataGrid;
        private DataGridViewTextBoxColumn code;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn dept;
        private DataGridViewTextBoxColumn credits;
        private DataGridViewTextBoxColumn day;
        private DataGridViewTextBoxColumn time;
        private DataGridViewTextBoxColumn descr;
        private Panel registration_titlePnl;
        private PictureBox charges_titleIcon;
        private Label charges_titleLbl;
        private Button registration_recommendedBtn;
        private Panel charges_unpaidCharges;
        private ComboBox registration_deptSelection;
        private Button registration_searchBtn;
        private Label registration_semesterLbl;
        private ComboBox registration_semesterSelection;
        private Label registration_searchLbl;
        private TextBox registration_searchBox;
        private Button charges_payBtn;
        private Button charges_unpaidBtn;
        private Button charges_paidBtn;
        private DataGridView charges_chargesDataGrid;
        private Panel charges_headerPnl;
        private Label charges_totalUnpaid;
        private Label charges_acctNumLbl;
        private Label charges_totalPaid;
        private Label charges_semesterLbl;
        private ComboBox details_payMethodMenu;
        private Label details_payMethodLbl;
        private Panel charges_methodPnl;
        private TextBox cc_mmText;
        private TextBox cc_numText;
        private TextBox cc_nameText;
        private TextBox cc_yyyyText;
        private Label cc_expLbl;
        private Label cc_nameLbl;
        private Label cc_numLbl;
        private Label bank_routingLbl;
        private TextBox bank_routingText;
        private Label bank_acctLbl;
        private TextBox bank_acctText;
        private Panel panel1;
        private Label label1;
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
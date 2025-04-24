using myKSU_v3.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myKSU_v3
{
    public partial class myChargesForm : Form
    {
        private myHomeForm homeForm;  // for nav back to home
        private Student student { get; set; }
        private ChargeAccount chargeAccount { get; set; }
        private University university { get; set; }
        private AdvisorBot bot { get; set; }

        private List<Charge>? paidCharges = new();
        private List<Charge>? unpaidCharges = new();

        public myChargesForm(myHomeForm homeForm, Student s, ChargeAccount ca, University u, AdvisorBot ab)
        {
            InitializeComponent();

            this.homeForm = homeForm;
            this.student = s;
            this.chargeAccount = ca;
            this.university = u;
            this.bot = ab;

            loadHeaderData();                 // populate header data above charges datagrid
            chatbot_mainPnl.Visible = false;  // set chatbot panel to hidden on load
        }


        //
        // NAV TO HOME & HELP BUTTONS
        //
        private void charges_backBtn_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            this.Hide();
        }
        private void charges_helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Placeholder text for myCharges");
        }


        //
        // CHANGE BASIC DATA LABELS TEXT
        //
        private void loadHeaderData()
        {
            charges_semesterLbl.Text += " " + university.semester;                          // get semester (Fall 2026)
            charges_acctNumLbl.Text += " " + chargeAccount.accountNumber;                   // get acct number
            charges_totalPaid.Text += " " + chargeAccount.SumPaidCharges().ToString();      // get sum of isPaid
            charges_totalUnpaid.Text += " " + chargeAccount.SumUnpaidCharges().ToString();  // get sum of !isPaid
        }


        //
        // SHOW UNPAID CHARGES
        //
        private void charges_unpaidBtn_Click(object sender, EventArgs e)
        {
            charges_methodPnl.Visible = true;                       // show payment details panel
            unpaidCharges = chargeAccount.GetUnpaidCharges();          // get list of unpaid charges

            // CLEAR COLUMNS
            charges_chargesDataGrid.Columns.Clear();                // reset columns

            // CONFIG COLUMNS
            charges_chargesDataGrid.AutoGenerateColumns = false;    // config columns
            charges_chargesDataGrid.RowHeadersVisible = false;      // remove blank row header
            charges_chargesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  // select full rows


            // ADD COLUMNS FOR UNPAID CHARGE FIELDS
            charges_chargesDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "amount",
                HeaderText = "Amount",
            });
            charges_chargesDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "dueDate",
                HeaderText = "Due Date",
            });
            charges_chargesDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "description",
                HeaderText = "Description",
                Width = 200
            });

            charges_chargesDataGrid.DataSource = null;            // reset to refresh data source
            charges_chargesDataGrid.DataSource = unpaidCharges;   // rebind list of unpaid charges to data grid
            charges_chargesDataGrid.ClearSelection();             // prevent default highlighting of top row
            charges_methodPnl.Visible = unpaidCharges.Count > 0;  // show if there are one or more unpaid charges remaining
        }


        //
        // SHOW PAID CHARGES 
        //
        private void charges_paidBtn_Click(object sender, EventArgs e)
        {
            charges_methodPnl.Visible = false;              // hide payment details panel
            paidCharges = chargeAccount.GetPaidCharges();   // get list of paid charges

            charges_chargesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  // select full rows

            charges_chargesDataGrid.Columns.Clear();               // reset to refresh datagrid 
            charges_chargesDataGrid.AutoGenerateColumns = false;
            charges_chargesDataGrid.RowHeadersVisible = false;

            charges_chargesDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "paymentId",
                HeaderText = "PaymentID",
            });
            charges_chargesDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "amount",
                HeaderText = "Amount",
            });
            charges_chargesDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "paidDate",
                HeaderText = "Date Paid"
            });
            charges_chargesDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "paymentMethod",
                HeaderText = "Pay Method",
            });
            charges_chargesDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "description",
                HeaderText = "Description",
                Width = 200
            });

            charges_chargesDataGrid.DataSource = null;         // reset to refresh data source
            charges_chargesDataGrid.DataSource = paidCharges;  // bind list of paid charges to data grid
            charges_chargesDataGrid.ClearSelection();          // prevent default highlighting of top row
        }


        //
        // PAYMENT BUTTON
        //
        private void charges_payBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payment Gateway API disabled for prototype.");
        }



        //
        // SET READONLY & COLOR OF TEXTBOXES PER PAYMENT METHOD
        //
        private void details_payMethodMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (details_payMethodMenu.SelectedItem == null) 
                return;

            string selectedMethod = details_payMethodMenu.SelectedItem.ToString().ToLower();
            if (selectedMethod.Contains("select"))
            {
                EnableCardPaymentDetailsUI();
                return;
            }

            if (selectedMethod.Contains("bank"))
            {
                EnableBankPaymentDetailsUI();
                return;
            }
            return;
        }

        // HELPER METHODS FOR SETTING UI ELEMENTS PER PAYMENT
        private void EnableCardPaymentDetailsUI()
        {
            cc_numText.BackColor = Color.White;             // set card inputs color to indicate useable
            cc_nameText.BackColor = Color.White;
            cc_mmText.BackColor = Color.White;
            cc_yyyyText.BackColor = Color.White;

            bank_acctText.BackColor = Color.WhiteSmoke;     // set bank inputs color to indicate not useable
            bank_routingText.BackColor = Color.WhiteSmoke;
        }
        private void EnableBankPaymentDetailsUI()
        {
            bank_acctText.BackColor = Color.White;
            bank_routingText.BackColor = Color.White;
            cc_numText.BackColor = Color.WhiteSmoke;
            cc_nameText.BackColor = Color.WhiteSmoke;
            cc_mmText.BackColor = Color.WhiteSmoke;
            cc_yyyyText.BackColor = Color.WhiteSmoke;
        }
        private void ResetDetailsUI()
        {
            bank_acctText.BackColor = Color.WhiteSmoke;      // set all to whitesmoke
            bank_routingText.BackColor = Color.WhiteSmoke;
            cc_numText.BackColor = Color.WhiteSmoke;
            cc_nameText.BackColor = Color.WhiteSmoke;
            cc_mmText.BackColor = Color.WhiteSmoke;
            cc_yyyyText.BackColor = Color.WhiteSmoke;
        }



        //
        // CHATBOT LOGIC
        //
        private void chatbot_owlPic_Click(object sender, EventArgs e) =>
            chatbot_mainPnl.Visible = !chatbot_mainPnl.Visible;                    // visibility set to opposite of current state

        private void chatbot_askBtn_Click(object sender, EventArgs e)
        {
            string userInput = chatbot_questionTextBox.Text.Trim();                // get input from textbox

            if (string.IsNullOrEmpty(userInput))
                chatbot_replyText.Text = "Hoot! You forgot to ask me a question!";  // confirm input len > 0

            string reply = bot.Respond(userInput);                                  // pass input to be parsed & keyword matched
            chatbot_replyText.Text = reply;                                         // show reponse in output region
        }

        private void chatbot_helpLbl_Click(object sender, EventArgs e) =>
            chatbot_replyText.Text = "Hoot! I can answer questions about your GPA, major, class standing, and enrolled courses. " +
            "I can also give other answers like the upcoming and info on offices like the Registrar's Office or Tech Support." +
            "I can also provide info about KSU like address, current semester, and upcoming add/drop deadline.";

        private void chatbot_exitLbl_Click(object sender, EventArgs e) =>
            chatbot_mainPnl.Visible = false;                                        // hide panel
    }
}

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

        private List<Charge> paidCharges;
        private List<Charge> unpaidCharges;

        public myChargesForm(myHomeForm homeForm, Student s, ChargeAccount ca, University u, AdvisorBot ab)
        {
            InitializeComponent();

            this.homeForm = homeForm;
            this.student = s;
            this.chargeAccount = ca;
            this.university = u;
            this.bot = ab;

            loadHeaderData();   // populate informational data above datagrid
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
            charges_totalPaid.Text += " " + chargeAccount.sumPaidCharges().ToString();      // get sum of isPaid
            charges_totalUnpaid.Text += " " + chargeAccount.sumUnpaidCharges().ToString();  // get sum of !isPaid
        }

        //
        // SHOW UNPAID CHARGES
        //
        private void charges_unpaidBtn_Click(object sender, EventArgs e)
        {
            charges_methodPnl.Visible = true;                       // show payment details panel
            unpaidCharges = chargeAccount.getUnpaidCharges();          // get list of unpaid charges

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
                DataPropertyName = "isPaid",
                HeaderText = "Paid",
            });
            charges_chargesDataGrid.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "description",
                HeaderText = "Description",
                Width = 200
            });

            charges_chargesDataGrid.DataSource = null;            // reset to refresh data source
            charges_chargesDataGrid.DataSource = unpaidCharges;   // bind list of unpaid charges to data grid
            charges_chargesDataGrid.ClearSelection();             // prevent default highlighting of top row
            charges_methodPnl.Visible = unpaidCharges.Count > 0;  // show if there are one or more unpaid charges remaining
        }

        //
        // SHOW PAID CHARGES 
        //
        private void charges_paidBtn_Click(object sender, EventArgs e)
        {
            charges_methodPnl.Visible = true;              // hide payment details panel
            charges_payBtn.Visible = false;                // hide pay course button
            paidCharges = chargeAccount.getPaidCharges();  // get list of paid charges

            charges_chargesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;  // select full rows

            charges_chargesDataGrid.Columns.Clear();
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
                DataPropertyName = "paidDateFormatted",
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
            paidCharges = chargeAccount.getPaidCharges();      // get paid charges list
            unpaidCharges = chargeAccount.getUnpaidCharges();  // get unpaid charges list

            if (charges_chargesDataGrid.SelectedRows.Count == 0)  // confirm a row has been selected
            {
                MessageBox.Show("No unpaid charge has been selected.", "Warning:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Charge selectedCharge = (Charge)charges_chargesDataGrid.SelectedRows[0].DataBoundItem;  // get selected charge

            if (selectedCharge.isPaid)  // confirm charge.isPaid == false
            {
                MessageBox.Show("This charge has already been paid.", "Warning:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            unpaidCharges.Remove(selectedCharge);                             // remove from list of unpaid charges
            paidCharges.Add(selectedCharge);                                  // add to list of paid charges
            selectedCharge.paidDate = DateOnly.FromDateTime(DateTime.Today);  // set from null to today (yyyy-mm-dd)
            DataLoader.saveChargeAccountData(chargeAccount);                  // update ChargeAccount.json file

            details_payMethodMenu.SelectedIndex = 0;  // set dropdown to first option
        }

        //
        // SET READONLY & COLOR OF TEXTBOXES PER PAYMENT METHOD
        //
        private void details_payMethodMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string method = details_payMethodMenu.SelectedItem.ToString().ToLower();

            if (method == "credit card")
            {
                cc_numText.ReadOnly = false; cc_numText.BackColor = Color.White;
                cc_nameText.ReadOnly = false; cc_nameText.BackColor = Color.White;
                cc_mmText.ReadOnly = false; cc_mmText.BackColor = Color.White;
                cc_yyyyText.ReadOnly = false; cc_yyyyText.BackColor = Color.White;

                bank_acctText.ReadOnly = true; bank_acctText.BackColor = Color.White;
                bank_routingText.ReadOnly = true; bank_routingText.BackColor = Color.White;

                return;
            }
            if (method == "bank transfer")
            {
                bank_acctText.ReadOnly = false; bank_acctText.BackColor = Color.White;
                bank_routingText.ReadOnly = false; bank_routingText.BackColor = Color.White;

                cc_numText.ReadOnly = true; cc_numText.BackColor = Color.WhiteSmoke;
                cc_nameText.ReadOnly = true; cc_nameText.BackColor = Color.WhiteSmoke;
                cc_mmText.ReadOnly = true; cc_mmText.BackColor = Color.WhiteSmoke;
                cc_yyyyText.ReadOnly = true; cc_yyyyText.BackColor = Color.WhiteSmoke;

                return;
            }
            return;
        }

        // CHATBOT LOGIC
        private void chatbot_owlPic_Click(object sender, EventArgs e) =>
            chatbot_mainPnl.Visible = !chatbot_mainPnl.Visible;                    // visibility set to opposite of current state

        private void chatbot_askBtn_Click(object sender, EventArgs e)
        {
            string userInput = chatbot_questionTextBox.Text.Trim();                // get input from textbox

            if (string.IsNullOrEmpty(userInput))
                chatbot_replyText.Text = "Hoot! You forgot to ask me a question!";  // confirm input len > 0

            string reply = bot.parseChatbotReply(userInput);                    // pass input to be parsed & keyword/regex matched
            chatbot_replyText.Text = reply;                                         // show reponse in output region
        }

        private void chatbot_helpLbl_Click(object sender, EventArgs e) =>
            chatbot_replyText.Text = "Hoot! I can answer questions about your GPA, major, class standing, and enrolled courses. I can also give other answers like the next registration add/drop deadline and info on offices like the Registrar's Office or Campus Police.";

        private void chatbot_exitLbl_Click(object sender, EventArgs e) =>
            chatbot_mainPnl.Visible = false;                                        // hide panel
    }
}

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
    public partial class myHomeForm : Form
    {
        // STORE OBJECTS FROM LOGIN & PASSED BETWEEN HOME & FORMS TO MAINTAIN OBJECT STATES
        private Student student { get; set; }
        private CourseManager courseManager { get; set; }
        private University university { get; set; }
        private ChargeAccount chargeAccount { get; set; }
        private Profile profile { get; set; }
        private AdvisorBot bot { get; set; }

        // GET OBJECTS FROM LOGIN OR WHEN NAVIGATING BACK TO HOME
        public myHomeForm(Student s, CourseManager cm, University u, ChargeAccount ca, Profile p, AdvisorBot ab)
        {
            InitializeComponent();

            this.student = s;          // objects were created with data from json files via DataLoader.loadFromJson()
            this.courseManager = cm;   // objects are then passed to homeForm from where they are passed to child forms
            this.university = u;
            this.chargeAccount = ca;
            this.profile = p;
            this.bot = ab;

            chatbot_mainPnl.Visible = false;  // set chatbot panel to hidden on load
        }

        // HELP & LOGOUT BUTTONS
        private void home_helpBtn_Click(object sender, EventArgs e) => MessageBox.Show("Placeholder text");
        private void home_exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will log you out of your account.", "Proceed?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                myLoginForm loginForm = new myLoginForm();  // logout = reset states & return to myLogin
                loginForm.Show();
                this.Close();
            }
        }

        // NAVIGATION
        private void home_myCoursesBtn_Click(object sender, EventArgs e)
        {
            myCoursesForm coursesForm = new myCoursesForm(this, this.student, this.courseManager, this.university, this.bot);
            coursesForm.Show();
            this.Hide();
        }
        private void home_myRegistrationBtn_Click(object sender, EventArgs e)
        {
            myRegistrationForm registrationForm = new myRegistrationForm(this, this.student, this.courseManager, this.university, this.bot);
            registrationForm.Show();
            this.Hide();
        }
        private void home_mySheduleBtn_Click(object sender, EventArgs e)
        {
            myScheduleForm scheduleForm = new myScheduleForm(this, this.student, this.bot);
            scheduleForm.Show();
            this.Hide();
        }
        private void home_myPaymentsBtn_Click(object sender, EventArgs e)
        {
            myChargesForm paymentsForm = new myChargesForm(this, this.student, this.chargeAccount, this.university, this.bot);
            paymentsForm.Show();
            this.Hide();
        }
        private void home_myProfileBtn_Click(object sender, EventArgs e)
        {
            myProfileForm profileForm = new myProfileForm(this, this.student, this.profile, this.bot);
            profileForm.Show();
            this.Hide();
        }

        // CHATBOT LOGIC
        private void chatbot_owlPic_Click(object sender, EventArgs e) =>
            chatbot_mainPnl.Visible = !chatbot_mainPnl.Visible;                    // visibility set to opposite of current state

        private void chatbot_askBtn_Click(object sender, EventArgs e)
        {
            string userInput = chatbot_questionTextBox.Text.Trim();                // get input from textbox

            if (string.IsNullOrEmpty(userInput))
                chatbot_replyText.Text = "Hoot! You forgot to ask me a question!";  // confirm input len > 0

            string reply = bot.parseChatbotReply(userInput);                        // pass input to be parsed & keyword/regex matched
            chatbot_replyText.Text = reply;                                         // show reponse in output region
        }

        private void chatbot_helpLbl_Click(object sender, EventArgs e) =>
            chatbot_replyText.Text = "Hoot! I can answer questions about your GPA, major, class standing, enrolled courses, and previous courses.";

        private void chatbot_exitLbl_Click(object sender, EventArgs e) =>
            chatbot_mainPnl.Visible = false;                                        // hide panel
    }
}

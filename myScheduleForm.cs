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
    public partial class myScheduleForm : Form
    {
        private myHomeForm homeForm { get; set; }
        private Student student { get; set; }
        private AdvisorBot bot { get; set; }

        public myScheduleForm(myHomeForm h, Student s, AdvisorBot ab)
        {
            InitializeComponent();

            this.homeForm = h;
            this.student = s;

            populateSchedule(s);

            chatbot_mainPnl.Visible = false;  // ensure chatbot panel is hidden on load
        }

        // NAV TO HOME & HELP BUTTONS
        private void schedule_backBtn_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            this.Hide();
        }
        private void schedule_helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Placeholder text for mySchedule.");
        }

        // POPULATE SCHEDULE DATAGRIDVIEW
        public void populateSchedule(Student student)
        {
            foreach (var course in student.enrolledCourses)
            {
                foreach (var day in course.meetingTimes.Keys)
                {
                    string code = course.code;
                    string name = course.name;
                    string weekDay = day;
                    string time = course.meetingTimes[day];

                    schedule_dataGrid.Rows.Add(code, name, weekDay, time);
                }
            }
        }

        // EXPORT TO PDF (DISABLED FOR PROTOTYPE)
        private void schedule_exportBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Disabled for prototype.");
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

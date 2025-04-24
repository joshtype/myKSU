using myKSU_v3.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        // HELP & NAV TO HOME BUTTONS
        private void schedule_helpBtn_Click(object sender, EventArgs e) => MessageBox.Show("Placeholder text for mySchedule.");
        private void schedule_backBtn_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            this.Hide();
        }

        // EXPORT TO PDF BUTTON
        private void schedule_exportBtn_Click(object sender, EventArgs e) => MessageBox.Show("Disabled for prototype.");


        //
        // POPULATE SCHEDULE DATAGRIDVIEW
        //
        public void populateSchedule(Student student)
        {
            foreach (var course in student.enrolledCourses)
            {
                if (course.meetingTimes == null || course.meetingTimes.Count == 0)
                {
                    schedule_dataGrid.Rows.Add("Online", "Async.", course.name, course.code);  // add online info & continue
                    continue;
                }

                foreach (var day in course.meetingTimes.Keys)  // iterate thru meeting times to display
                {
                    string eachDay = day;
                    string eachTime = course.meetingTimes[day];  
                    string eachName = course.name;
                    string eachCode = course.code;

                    schedule_dataGrid.Rows.Add(eachDay, eachTime, eachName, eachCode);
                }
            }
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
            chatbot_mainPnl.Visible = false;                                         // hide panel   
    }
}

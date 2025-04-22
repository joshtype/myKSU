using myKSU_v3.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myKSU_v3
{
    public partial class myCoursesForm : Form
    {
        private myHomeForm homeForm { get; set; }
        private Student student { get; set; }
        private CourseManager courseManager { get; set; }
        private University university { get; set; }
        private AdvisorBot bot { get; set; }

        public myCoursesForm(myHomeForm home, Student s, CourseManager cm, University u, AdvisorBot ab)
        {
            InitializeComponent();

            this.homeForm = home;
            this.student = s;
            this.courseManager = cm;
            this.university = u;
            this.bot = ab;

            chatbot_mainPnl.Visible = false;                         // set chatbot panel to hidden on form load
            courses_semesterLbl.Text = university.semester + ":";    // show semester in enrolled courses header

            courses_enrolledList.SelectedIndexChanged += viewSelectedCourseData;  // bind enrolled courses list
            loadEnrolledCourses();  // show all courses
        }

        // HELP & BACK TO HOME NAV BUTTONS
        private void courses_helpBtn_Click(object sender, EventArgs e) => MessageBox.Show("Placeholder help text for myCourses.");
        private void courses_backBtn_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            this.Hide();
        }

        // POPULATE LIST OF CURRENTLY ENROLLED COURSES
        private void loadEnrolledCourses()
        {
            courses_enrolledList.DataSource = null;                     // reset list on form load
            courses_enrolledList.DataSource = student.enrolledCourses;  // populate from enrolled course list
        }

        // DISPLAY COURSE DATA OF SELECTED COURSE
        private void viewSelectedCourseData(object sender, EventArgs e)
        {
            Course selectedCourse = (Course)courses_enrolledList.SelectedItem;  // cast selection to Course type

            if (selectedCourse != null)
            {
                info_codeCell.Text = selectedCourse.getCode();                // get course object attributes for readonly textboxes
                info_nameCell.Text = selectedCourse.getName();
                info_deptCell.Text = selectedCourse.getDepartment();
                info_descCell.Text = selectedCourse.getDescription();
                info_credCell.Text = selectedCourse.getCredits().ToString();  // parse int to string
                info_typeCell.Text = selectedCourse.getType();

                if (selectedCourse.getType() == "online")
                {
                    // online courses meeting times set to null in json file
                    info_meetCell.Text = "Asynchronous";
                }
                else
                {
                    // if in-person & dictionary set to meetingTimes, parse strings of "Day: time slot" on new lines
                    info_meetCell.Text = string.Join(", ",
                    selectedCourse.getMeetingTimes().Select(mt => $"{mt.Key}: {mt.Value}\n"));  // key=day : value=time
                }
            }
        }

        // UNENROLL COURSE 
        private void courses_unenrollBtn_Click(object sender, EventArgs e)
        {
            if (courses_enrolledList.SelectedItem == null)
            {
                MessageBox.Show("Please select a course to unenroll.", "No course selected.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Confirm unenrollment attempt? If you have questions or concerns, contact your advisor first!\n",
                "Confirm unenrollment attempt:", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
            {
                return;  // if dialog box returns anything but yes then exit method
            }

            Course selectedCourse = (Course)courses_enrolledList.SelectedItem;  // get course obj from list selection

            string result = courseManager.unenrollCourse(student, selectedCourse, university);
            if (result.StartsWith("SUCCESS"))
            {
                student.enrolledCourses.RemoveAll(
                    c => c.code == selectedCourse.code);            // remove course from enrolled list

                courses_enrolledList.DataSource = null;             // reset list data source
                loadEnrolledCourses();                              // re-populate list

                info_codeCell.Clear();                              // set course attribute textboxes to empty
                info_nameCell.Clear();
                info_deptCell.Clear();
                info_descCell.Clear();
                info_credCell.Clear();
                info_typeCell.Clear();
                info_meetCell.Clear();

                DataLoader.saveStudentData(student);                // update student json file
            }
            else
            {
                // display failure reason
                MessageBox.Show(result, "Unenrollment Attempt Status:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

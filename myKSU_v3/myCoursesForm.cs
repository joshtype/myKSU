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

        // INITIALIZE WITH OBJECTS PASSED FROM HOME FORM
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

            courses_enrolledList.SelectedIndexChanged += ViewSelectedCourseData;  // bind enrolled courses list
            LoadEnrolledCourses();  // show all courses
        }

        // HELP & BACK TO HOME NAV BUTTONS
        private void courses_helpBtn_Click(object sender, EventArgs e) => MessageBox.Show("Placeholder help text for myCourses.");
        private void courses_backBtn_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            this.Hide();
        }


        //
        // POPULATE LIST OF CURRENTLY ENROLLED COURSES
        //
        private void LoadEnrolledCourses()
        {
            courses_enrolledList.DataSource = null;                     // reset list on form load
            courses_enrolledList.DataSource = student.enrolledCourses;  // populate from enrolled course list
        }


        //
        // DISPLAY PROPERTIES OF SELECTED COURSE
        //
        private void ViewSelectedCourseData(object sender, EventArgs e)
        {
            Course selectedCourse = (Course)courses_enrolledList.SelectedItem;  // cast selection to Course type

            if (selectedCourse != null)
            {
                info_codeCell.Text = selectedCourse.GetCode();                  // get course object attributes for readonly textboxes
                info_nameCell.Text = selectedCourse.GetName();
                info_deptCell.Text = selectedCourse.GetDepartment();
                info_descCell.Text = selectedCourse.GetDescription();
                info_credCell.Text = selectedCourse.GetCredits().ToString();    // parse int to string
                info_typeCell.Text = selectedCourse.GetType();

                if (selectedCourse.GetType() == "Online")
                {
                    // online courses meeting times set to null in json file
                    info_meetCell.Text = "Asynchronous";
                }
                else
                {
                    // if in-person & dictionary set to meetingTimes, parse strings of "Day: time slot" on new lines
                    info_meetCell.Text = string.Join(", ",
                    selectedCourse.GetMeetingTimes().Select(mt => $"{mt.Key}: {mt.Value}\n"));  // key=day : value=time
                }
            }
        }


        //
        // UNENROLL COURSE 
        //
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

            if (confirm != DialogResult.Yes)  // exit if user cancels
                return;

            Course selectedCourse = (Course)courses_enrolledList.SelectedItem;
            if (courseManager.UnenrollCourse(student, selectedCourse, university))  // remove course from display & student.enrolledCourse
            {
                UpdateAfterUnenrollment();
                DataLoader.SaveStudentData(student);
            }
            else
                MessageBox.Show("Unenrollment failed. Make sure the deadline hasn't passed and you're enrolled in the course.",
                    "Unenrollment Attempt Status:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // HELPER METHOD TO RESET UI CONTROLS
        private void UpdateAfterUnenrollment()
        {
            courses_enrolledList.DataSource = null;
            LoadEnrolledCourses();

            info_codeCell.Clear();
            info_nameCell.Clear();
            info_deptCell.Clear();
            info_descCell.Clear();
            info_credCell.Clear();
            info_typeCell.Clear();
            info_meetCell.Clear();

            MessageBox.Show("Unenrollment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

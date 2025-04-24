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
    public partial class myRegistrationForm : Form
    {
        private myHomeForm homeForm { get; set; }
        private Student student { get; set; }
        private CourseManager courseManager { get; set; }
        private University university { get; set; }
        private AdvisorBot bot { get; set; }
        private List<Course> displayedCourses = new List<Course>();  // maintain search results state

        public myRegistrationForm(myHomeForm home, Student s, CourseManager cm, University u, AdvisorBot ab)
        {
            InitializeComponent();

            this.homeForm = home;
            this.student = s;
            this.courseManager = cm;
            this.university = u;
            this.bot = ab;

            showAllCourses();  // show all courses in catalog.json on form load

            registration_deptSelection.SelectedIndex = 0;               // set drop-downs to first option on load
            registration_semesterSelection.SelectedIndex = 0;

            chatbot_mainPnl.Visible = false;                            // ensure chatbot panel is hidden on load

            registration_catalogDataGrid.ScrollBars = ScrollBars.Both;                                // show both scrollbars
            registration_catalogDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;  // enable dynamic sizing 
            registration_catalogDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;    
        }


        //
        // HELP & BACK TO HOME BUTTONS
        //
        private void registration_helpBtn_Click(object sender, EventArgs e) => MessageBox.Show("Placeholder text for myRegistration.");
        private void registration_backBtn_Click(object sender, EventArgs e)
        {
            homeForm.Show();
            this.Hide();
        }


        //
        // POPULATE WITH ALL COURSES 
        //
        private void showAllCourses()
        {
            registration_catalogDataGrid.Rows.Clear();  // reset datagrid on form load

            foreach (var course in courseManager.catalogFall2026)
            {
                string day, time;

                if (course.meetingTimes != null && course.meetingTimes.Count > 0)
                {
                    // online courses have null meetingTimes dictionaries
                    day = string.Join(", ", course.meetingTimes.Keys);     // if course.type != "online"
                    time = string.Join(", ", course.meetingTimes.Values);  // get keys (days) & values (times)
                }
                else
                {
                    day = "Online";  // if course.type == "online"
                    time = "Async";  // set day, time accordingly
                }

                registration_catalogDataGrid.Rows.Add(
                    course.code,
                    course.name,
                    course.department,
                    course.credits,
                    day,
                    time
                );
            }
        }


        //
        // APPLY KEYWORD & DEPARTMENT FILTERED COURSES
        //
        private void displayResults(List<Course> searchResultCourses)
        {
            registration_catalogDataGrid.Rows.Clear();  // clear current displayed courses

            if (searchResultCourses != null)
            {
                foreach (var course in searchResultCourses)
                {
                    string day = course.meetingTimes != null && course.meetingTimes.Count > 0
                        ? string.Join(", ", course.meetingTimes.Keys) : "Online";

                    string time = course.meetingTimes != null && course.meetingTimes.Count > 0
                        ? string.Join(", ", course.meetingTimes.Values) : "Async";

                    int rowIndex = registration_catalogDataGrid.Rows.Add(
                        course.code,
                        course.name,
                        course.department,
                        course.credits,
                        day,
                        time
                    );
                }
            }
        }


        //
        // FILTER CURRENTLY SHOWN COURSES BY DEPARTMENT
        //
        private void registration_deptSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDepartment = registration_deptSelection.SelectedItem?.ToString();
            registration_searchBox.Clear();
            List<Course> allCourses = courseManager.catalogFall2026;

            List<Course> filtered = selectedDepartment == "All Departments"
                ? allCourses : allCourses
                .Where(c => c.department
                .Equals(selectedDepartment, StringComparison.OrdinalIgnoreCase))
                .ToList();

            displayedCourses = filtered;
            displayResults(filtered);
        }


        //
        // SEARCH CURRENTLY DISPLAYED COURSES BY KEYWORD
        //
        private void registration_searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = registration_searchBox.Text.Trim().ToLower();  // user input

            // filter catalog by keyword in name & code, ignore currently/previously enrolled courses
            List<Course> filteredCourses = courseManager.SearchByKeyword(student, keyword);

            displayResults(filteredCourses);  // update list of courses
        }


        //
        // RESET DISPLAYED COURSES TO ENTIRE CATALOG
        //
        private void registration_resetBtn_Click(object sender, EventArgs e)
        {
            registration_deptSelection.SelectedIndex = 0;  // reset dept drop-down
            registration_searchBox.Clear();                // clear keyword textbox
            showAllCourses();                      // reload datagrid to all courses
        }


        //
        // GET RECOMMENDED COURSES
        //
        private void registration_recommendedBtn_Click(object sender, EventArgs e)
        {
            List<Course> recommendedCourses = courseManager.GenerateRecommendations(student);

            if (recommendedCourses != null && recommendedCourses.Count > 0)
            {
                displayedCourses = recommendedCourses;
                displayResults(recommendedCourses);
            }
            else
            {
                registration_catalogDataGrid.Rows.Clear();  // clear catalog display
                registration_catalogDataGrid.Rows.Add(
                    "-", "No recommended courses at this time.", "-", "-", "-", "-", "-"
                );
            }

            registration_deptSelection.SelectedIndex = 0;  // reset drop-down menu to 'All Departments'
            registration_searchBox.Clear();                // clear search textbox
        }


        //
        // ENROLL SELECTED COURSE
        //
        private void registration_enrollBtn_Click(object sender, EventArgs e)
        {
            if (registration_catalogDataGrid.SelectedRows.Count == 0)  // Check if a row is selected
            {
                MessageBox.Show("No course has been selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = registration_catalogDataGrid.SelectedRows[0];  // Get selected row
            string courseCode = selectedRow.Cells["code"].Value.ToString();  // Get course code

            Course selectedCourse = courseManager.catalogFall2026.FirstOrDefault(c => c.code == courseCode);

            if (selectedCourse == null)
            {
                MessageBox.Show("The selected course could not be found.");
                return;
            }

            DialogResult confirm = MessageBox.Show($"Do you want to enroll in {selectedCourse.code}: {selectedCourse.name} -" +
                $"({selectedCourse.description})?",
                "Confirm enrollment",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                string result = courseManager.EnrollCourse(student, selectedCourse, university);
                MessageBox.Show(result, "Enrollment Attempt Status:", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (result == "SUCCESS")  // Fix capitalization for consistency
                    DataLoader.SaveStudentData(student);
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
            chatbot_mainPnl.Visible = false;                                        // hide panel   
    }
}

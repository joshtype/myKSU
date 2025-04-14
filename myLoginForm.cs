using myKSU_v3.Library;
namespace myKSU_v3
{
    public partial class myLoginForm : Form
    {
        public myLoginForm()
        {
            InitializeComponent();
        }

        private void login_authenticateBtn_Click(object sender, EventArgs e)
        {
            login_errorLbl.Visible = false;      // reset error label to invisible

            string email = login_emailTxt.Text.Trim();  // get strings from text inputs
            string pass = login_passTxt.Text.Trim();
            string id = login_idTxt.Text.Trim();

            // hardcoded authentication
            if (email == "" || pass == "" || id == "")
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }
            if (email == "testEmail@ksu.edu" && pass == "testPass1" && id == "9")
            {
                // create object models from json files
                Student student = DataLoader.loadStudent();              
                CourseManager courseManager = DataLoader.loadCourseManager();  // catalogFall2026 & course-related tasks
                University university = DataLoader.loadUniversity();         

                // create forms so objects & forms can be passed between without reinitializiing
                myHomeForm homeForm = new myHomeForm(student, courseManager, university);
                homeForm.Show();
                this.Hide();
            }
            else
            {
                login_errorLbl.Visible = true;  // display error label
                login_emailTxt.Clear();         // clear text inputs
                login_passTxt.Clear();
                login_idTxt.Clear();
            }
        }

        private void login_helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prototype test credentials:\nKSU Email: testEmail@ksu.edu\nKSU Password: testPass1\nKSU ID: 9");
        }
    }
}

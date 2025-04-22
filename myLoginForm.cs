using myKSU_v3.Library;

namespace myKSU_v3
{
    public partial class myLoginForm : Form
    {
        // WILL BE FILLED FROM JSON OR USING OTHER OBJECTS
        private Student student;
        private CourseManager courseManager;
        private University university;
        private ChargeAccount chargeAccount;
        private Profile profile;
        private AdvisorBot bot;

        public myLoginForm()
        {
            InitializeComponent();
        }

        private void login_authenticateBtn_Click(object sender, EventArgs e)
        {
            login_errorLbl.Visible = false;             // hide error label

            string email = login_emailTxt.Text.Trim();  // get user input from text boxes
            string pass = login_passTxt.Text.Trim();
            string id = login_idTxt.Text.Trim();

            // authentication
            if (email == "" || pass == "" || id == "")
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            if (email == "email" && pass == "pass" && id == "1")
            {
                this.student = DataLoader.loadStudent();                         // fill objects from json files
                this.courseManager = DataLoader.loadCourseManager();
                this.university = DataLoader.loadUniversity();
                this.chargeAccount = DataLoader.loadChargeAccount();
                this.profile = DataLoader.loadProfile();
                this.bot = new AdvisorBot(student, courseManager, university);  // use above fields to init advisor object

                myHomeForm homeForm = new myHomeForm(student, courseManager, university, chargeAccount, profile, bot);
                homeForm.Show();
                this.Hide();      // do not use Close() as it will reset object states
            }
            else
            {
                login_errorLbl.Visible = true;          // error label set to visible
                login_prototypeHelpLbl.Visible = true;  // error label for prototype

                login_emailTxt.Clear();                 // clear text inputs
                login_passTxt.Clear();
                login_idTxt.Clear();
            }
        }

        // HELP & EXIT BUTTONS
        private void login_helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prototype test credentials:\nKSU Email = 'email'\nKSU Password = 'pass'\nKSU ID = '1'");
        }

        private void login_exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();  // reset states & close app
        }
    }
}

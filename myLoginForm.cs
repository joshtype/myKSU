using myKSU_v3.Library;

namespace myKSU_v3
{
    public partial class myLoginForm : Form
    {
        // DATA FOR FIELDS READ IN FROM JSON BY DataLoader.cs
        private Student student;              
        private CourseManager courseManager;
        private University university;
        private ChargeAccount chargeAccount;
        private Profile profile;

        private BotReplyManager replyManager;
        private AdvisorBot bot;

        // LOGIN FORM IS THE ONLY FORM CONSTRUCTOR TO NOT REQUIRE OBJECT ARGS
        public myLoginForm()
        {
            InitializeComponent();
        }

        // HELP & EXIT BUTTONS (EXIT CLOSES APP, RESETTING STATES)
        private void login_helpBtn_Click(object sender, EventArgs e) => MessageBox.Show("Prototype test credentials:\nKSU Email = 'email'\nKSU Password = 'pass'\nKSU ID = '1'");
        private void login_exitBtn_Click(object sender, EventArgs e) => this.Close();


        //
        // CHECK CREDENTIALS, CREATE NEEDED OBJECTS IF CORRECT
        //
        private void login_authenticateBtn_Click(object sender, EventArgs e)
        {
            login_errorLbl.Visible = false;             // hide error label
            login_prototypeHelpLbl.Visible = false;     // hide prototype error label

            string email = login_emailTxt.Text.Trim();  // get user input from text boxes
            string pass = login_passTxt.Text.Trim();
            string id = login_idTxt.Text.Trim();

            if (email == "" || pass == "" || id == "")
            {
                MessageBox.Show("Please enter all fields.");
                return;
            }

            if (email == "email" && pass == "pass" && id == "1")
            {
                // CREATE OBJECTS USING JSON READER
                this.student = DataLoader.LoadStudent();
                this.courseManager = DataLoader.LoadCourseManager();
                this.university = DataLoader.LoadUniversity();
                this.chargeAccount = DataLoader.LoadChargeAccount();
                this.profile = DataLoader.LoadProfile();

                // CREATE CHATBOT USING ABOVE OBJECTS
                this.replyManager = new BotReplyManager(university, student, courseManager);
                this.bot = new AdvisorBot(replyManager);

                // CREATE NEXT FORM, PASS ALL OBJECTS TO FORM EXCEPT BOTREPLYMANAGER
                myHomeForm homeForm = new myHomeForm(student, courseManager, university, chargeAccount, profile, bot);
                homeForm.Show();
                this.Hide();      // Close() resets object states so is not used for navigation
            }
            else
            {
                login_errorLbl.Visible = true;          // show error label
                login_prototypeHelpLbl.Visible = true;  // show prototype error label
                login_emailTxt.Clear();                 // clear textboxes
                login_passTxt.Clear();
                login_idTxt.Clear();
            }
        }


        
    }
}

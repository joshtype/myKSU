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
            login_errorLbl.Visible = false;

            string email = login_emailTxt.Text;
            string pass = login_passTxt.Text;
            string id = login_idTxt.Text;

            if (email == "test@students.kennesaw.edu" && pass == "Pass123" && id == "012345678")
            {
                var student = DataLoader.loadStudent();
                var catalogFall26 = DataLoader.loadCourses();
                var courseManager = DataLoader.loadCourseManager();
                var university = DataLoader.loadUniversity();

                var homeForm = new myHomeForm(student, catalogFall26, courseManager, university);

                homeForm.Show();
                this.Hide();
            }
            else
            {
                login_errorLbl.Visible = true;
                login_emailTxt.Clear();
                login_passTxt.Clear();
                login_idTxt.Clear();
            }
        }
    }
}

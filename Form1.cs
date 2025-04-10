namespace myKSU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // HELP & EXIT BUTTONS
        private void loginHelpBtn_Click(object sender, EventArgs e) => MessageBox.Show("Prototype credentials:\nEmail: sastude@students.ksu.edu\nPassword: passWord123\nID: 123456789");
        private void myHomeHelpBtn_Click(object sender, EventArgs e) => MessageBox.Show("myHome help information.");
        private void myCoursesHelpBtn_Click(object sender, EventArgs e) => MessageBox.Show("myProfile help information.");
        private void myRegisHelpBtn_Click(object sender, EventArgs e) => MessageBox.Show("myRegistration help information.");
        private void myScheduleHelpBtn_Click(object sender, EventArgs e) => MessageBox.Show("mySchedule help information.");
        private void myAdvisorHelpBtn_Click(object sender, EventArgs e) => MessageBox.Show("myAdvisor help information.");
        private void myPaymentsHelpBtn_Click(object sender, EventArgs e) => MessageBox.Show("myPayments help information.");
        private void myProfileHelpBtn_Click(object sender, EventArgs e) => MessageBox.Show("myProfile help information.");


        // LOGIN AUTHENTICATION
        private void button7_Click(object sender, EventArgs e)
        {
            String email = ksuEmailTextBox.Text;
            String pass = ksuPassTextBox.Text;
            String id = ksuIdTextBox.Text;

            if (email == "sastude@students.kennesaw.edu" && pass == "passWord123" && id == "123456789")
            {
                ksuEmailTextBox.Clear();
                ksuPassTextBox.Clear();
                ksuIdTextBox.Clear();
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                ksuEmailTextBox.Clear();
                ksuPassTextBox.Clear();
                ksuIdTextBox.Clear();
                MessageBox.Show("Invalid credentials. Click ? to view prototype credentials.");
            }
        }

        private void myHomeExitBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
    }
}

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
    public partial class myHomeForm : Form
    {
        private Student student;
        private CourseManager courseManager;
        private University university;

        public myHomeForm(Student s, CourseManager cm, University u)
        {
            InitializeComponent();

            this.student = s;
            this.courseManager = cm;
            this.university = u;
        }

        //
        // Nav to myCourses
        //
        private void home_myCoursesBtn_Click(object sender, EventArgs e)
        {
            // create myCourses form, pass in objects
            myCoursesForm coursesForm = new myCoursesForm(this, student, courseManager, university);
            this.Hide();
            coursesForm.Show();
        }

        private void home_exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "This will log you out of your account.",
                "Proceed?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if ( result == DialogResult.Yes )
            {
                myLoginForm loginForm = new myLoginForm();
                this.Close();
            }
        }

        //
        // Nav to myRegistration
        //

        //
        // Nav to mySchedule
        //

        //
        // Nav to myAdvisory
        //

        //
        // Nav to myPayments
        //

        //
        // Nav to myProfile
        //
    }
}

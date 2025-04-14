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
    public partial class myCoursesForm : Form
    {
        private myHomeForm homeForm;
        private Student student;
        private CourseManager catalogFall2026;
        private CourseManager courseManager;
        private University university;

        public myCoursesForm(myHomeForm home, Student s, CourseManager cm, University u)
        {
            InitializeComponent();

            this.homeForm = home;
            this.student = s;
            this.courseManager = cm;
            this.university = u;
        }

        private void courses_backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            homeForm.Show();
        }
        private void courses_helpBtn_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("Placeholder text for myCourses help.");
        }
    }
}

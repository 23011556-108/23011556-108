using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            // ✅ Originality Parameter
            this.Text = "Student Management System by Faizan";

            // Connect button events in constructor
            button1.Click += AddStudent_Click;
            button2.Click += ViewStudents_Click;
            button3.Click += Exit_Click;
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();
            addForm.ShowDialog();
        }

        private void ViewStudents_Click(object sender, EventArgs e)
        {
            ViewStudentsForm viewForm = new ViewStudentsForm();
            viewForm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
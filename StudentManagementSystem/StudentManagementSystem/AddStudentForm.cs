using System;
using System.Formats.Asn1;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagementSystem
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Get input values
              string name = textBox1.Text.Trim();
                int age = int.Parse(textBox2.Text.Trim());
                string studentClass = textBox3.Text.Trim();

                // Validate inputs
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter student name!");
                    return;
                }

                // Create and add new student
                Student newStudent = new Student(name, age, studentClass);
                DataStorage.Students.Add(newStudent);

                MessageBox.Show("Student added successfully!", "Success",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear fields for next entry
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid age!", "Input Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
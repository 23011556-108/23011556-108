using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm()
        {

            SetupDataGridView();
            LoadStudents();

            // Connect button events in constructor
            button1.Click += Refresh_Click;
            button2.Click += Delete_Click;
            button3.Click += Back_Click;
        }

        private void SetupDataGridView()
        {
            dataGridViewStudents.Columns.Clear();
            dataGridViewStudents.Columns.Add("Name", "Name");
            dataGridViewStudents.Columns.Add("Age", "Age");
            dataGridViewStudents.Columns.Add("Class", "Class");

            dataGridViewStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void LoadStudents()
        {
            try
            {
                dataGridViewStudents.Rows.Clear();

                foreach (Student student in DataStorage.Students)
                {
                    dataGridViewStudents.Rows.Add(student.Name, student.Age, student.Class);
                }

                this.Text = $"View Students - Total: {DataStorage.Students.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}");
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadStudents();
            MessageBox.Show("Data refreshed!");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow != null && dataGridViewStudents.CurrentRow.Index >= 0)
            {
                int selectedIndex = dataGridViewStudents.CurrentRow.Index;
                if (selectedIndex < DataStorage.Students.Count)
                {
                    string studentName = DataStorage.Students[selectedIndex].Name;

                    DialogResult result = MessageBox.Show(
                        $"Are you sure you want to delete {studentName}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        DataStorage.Students.RemoveAt(selectedIndex);
                        LoadStudents();
                        MessageBox.Show($"{studentName} deleted successfully!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete!");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {

        }
    }
}
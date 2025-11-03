using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Employee_Attendance
{
    public partial class Form1 : Form
    {
        private readonly List<Attendance> _attendances = new List<Attendance>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set a simple background color or image. If you have an image resource, set it here.
            this.BackgroundImageLayout = ImageLayout.Stretch;
            try
            {
                // Try to load a bundled image named "dashboard.jpg" in application folder
                var imgPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dashboard.jpg");
                if (System.IO.File.Exists(imgPath))
                {
                    this.BackgroundImage = Image.FromFile(imgPath);
                }
                else
                {
                    this.BackColor = Color.LightSteelBlue;
                }
            }
            catch
            {
                this.BackColor = Color.LightSteelBlue;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var name = txtEmployeeName.Text?.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter employee name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var attendance = new Attendance
            {
                EmployeeName = name,
                Date = dtpDate.Value.Date,
                IsPresent = chkPresent.Checked
            };

            _attendances.Add(attendance);
            lstAttendance.Items.Add(attendance);

            // clear name for convenience
            txtEmployeeName.Clear();
        }
    }
}

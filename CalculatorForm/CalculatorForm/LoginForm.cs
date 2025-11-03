using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                CalculatorForm calculatorForm = new CalculatorForm();
                calculatorForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }
    }
}

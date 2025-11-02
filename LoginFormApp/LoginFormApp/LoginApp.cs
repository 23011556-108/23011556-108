using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginFormApp
{
    public partial class LoginApp : Form
    {
        public LoginApp()
        {
            InitializeComponent();
        }

        private void LoginApp_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Define the required credentials
            string requiredUsername = "admin";
            string requiredPassword = "1234";

            // Get the user input
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            // Check the logic
            if (enteredUsername == requiredUsername && enteredPassword == requiredPassword)
            {
                // 1. Go to HomePage
                HomePage home = new HomePage();

                // Optional: Display the username in the welcome message
                home.SetWelcomeMessage(enteredUsername);

                home.Show(); // Show the HomePage
                this.Hide();  // Hide the current LoginForm
            }
            else
            {
                // 2. Show an error message
                MessageBox.Show("Invalid Username or Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Optional: Clear the password field for security
                txtPassword.Clear();
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginFormApp; // Use your project name here

namespace LoginFormApp
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        public void SetWelcomeMessage(string username)
        {
            // Make sure you have a Label control named 'lblWelcome' on HomePage
            // If your label is named Label1, change lblWelcome to Label1.
            lblWelcome.Text = $"Welcome, {username}!";
        }

    // Other methods (like btnLogout_Click) go here

        private void HomePage_Load(object sender, EventArgs e)
        {
            if (lblWelcome.Text == "lblWelcome") // Check if the message hasn't been set yet
            {
                lblWelcome.Text = "Welcome to the Home Page!";
            }
        }

        
        
            private void btnLogout_Click(object sender, EventArgs e)
        {
            // 3. Logout returns to LoginForm

            // Create a new instance of the LoginForm
            LoginApp login = new LoginApp();

            login.Show(); // Show the LoginForm
            this.Close(); // Close the current HomePage
        }
    }
    }


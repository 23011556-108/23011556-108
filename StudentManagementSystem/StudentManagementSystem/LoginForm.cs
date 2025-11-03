using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label2;

        public LoginForm()
        {
            CreateLoginForm();
        }

        private void CreateLoginForm()
        {
            // Form settings
            this.Text = "Login";
            this.Size = new System.Drawing.Size(300, 250);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Username Label
            label1 = new Label();
            label1.Text = "Username:";
            label1.Location = new System.Drawing.Point(30, 50);
            label1.Size = new System.Drawing.Size(60, 20);
            this.Controls.Add(label1);

            // Username TextBox
            txtUsername = new TextBox();
            txtUsername.Location = new System.Drawing.Point(100, 50);
            txtUsername.Size = new System.Drawing.Size(150, 20);
            this.Controls.Add(txtUsername);

            // Password Label
            label2 = new Label();
            label2.Text = "Password:";
            label2.Location = new System.Drawing.Point(30, 90);
            label2.Size = new System.Drawing.Size(60, 20);
            this.Controls.Add(label2);

            // Password TextBox
            txtPassword = new TextBox();
            txtPassword.Location = new System.Drawing.Point(100, 90);
            txtPassword.Size = new System.Drawing.Size(150, 20);
            txtPassword.PasswordChar = '*';
            this.Controls.Add(txtPassword);

            // Login Button
            btnLogin = new Button();
            btnLogin.Text = "Login";
            btnLogin.Location = new System.Drawing.Point(100, 130);
            btnLogin.Size = new System.Drawing.Size(150, 30);
            btnLogin.Click += btnLogin_Click;
            this.Controls.Add(btnLogin);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 54);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 134);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(198, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(149, 243);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 4;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginForm
            // 
            ClientSize = new Size(799, 389);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            ResumeLayout(false);
            PerformLayout();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "1234")
            {
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
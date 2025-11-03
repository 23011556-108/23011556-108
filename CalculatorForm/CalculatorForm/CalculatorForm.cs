using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CalculatorForm
{
    public partial class CalculatorForm : Form
    {
        public static List<string> calculationHistory = new List<string>();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Calculation(string operation)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("Cannot divide by zero.");
                            return;
                        }
                        break;
                }

                Result.Text = $"Result: {result}";
                string historyEntry = $"{num1} {operation} {num2} = {result}";
                calculationHistory.Add(historyEntry);
            }
            catch
            {
                MessageBox.Show("Error: Please enter valid numbers!");
            }
        }

        // ADD BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            Calculation("+");
        }






       

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculation("-");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculation("*");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculation("/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}

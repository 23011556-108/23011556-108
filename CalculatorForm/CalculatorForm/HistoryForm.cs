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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            LoadHistory();

        }
        private void LoadHistory()
        {
            listBox1.Items.Clear();
            foreach (string entry in CalculatorForm.calculationHistory)
            {
                listBox1.Items.Add(entry);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}

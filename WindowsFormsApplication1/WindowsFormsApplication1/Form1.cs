using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            lblSymbol.Text= "+";
            lblResult.Text = (a + b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            lblSymbol.Text = "-";
            lblResult.Text = (a - b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            lblSymbol.Text = "*";
            lblResult.Text = (a * b).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            lblSymbol.Text = "/";
            lblResult.Text = (a / b).ToString();
        }
    }
}

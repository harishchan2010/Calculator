using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator__1_
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output.Text = (Convert.ToInt32(Input1.Text) + Convert.ToInt32(Input2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Output.Text = (Convert.ToInt32(Input1.Text) - Convert.ToInt32(Input2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Output.Text = (Convert.ToInt32(Input1.Text) * Convert.ToInt32(Input2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Output.Text = (Convert.ToInt32(Input1.Text) / Convert.ToInt32(Input2.Text)).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Input1.Text = string.Empty;
            Input2.Text = string.Empty;
            Output.Text = string.Empty;
        }

        private void Input1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void Input2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void Output_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}

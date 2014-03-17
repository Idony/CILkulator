using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void multiplycationf_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(firstArgument.Text)*Convert.ToDouble(secondArgument.Text);
            resultField.Text = result.ToString();
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(firstArgument.Text) / Convert.ToDouble(secondArgument.Text);
            resultField.Text = result.ToString();
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            Addition adder = new Addition();
            resultField.Text = adder.Add(firstArgument.Text, secondArgument.Text);
        }

        private void substractionButton_Click(object sender, EventArgs e)
        {
            Addition adder = new Addition();
            resultField.Text = adder.Add(firstArgument.Text, secondArgument.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


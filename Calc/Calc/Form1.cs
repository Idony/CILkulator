using System;
using System.Windows.Forms;
using Calc.BinaryCalculators;
using Calc.SingleCalculators;

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

        private void Calculate(string name)
        {
            if (!string.IsNullOrEmpty(firstArgument.Text.Trim()) && !string.IsNullOrEmpty(secondArgument.Text.Trim()))
            {
                IBinaryOperation calculator = BinaryOperationFactory.Create(name);
                resultField.Text =calculator.Calculation(Convert.ToDouble(firstArgument.Text), Convert.ToDouble(secondArgument.Text)).ToString();
            }
        }

        private void SCalculate(string name)
        {
             if (!string.IsNullOrEmpty(firstArgument.Text.Trim()))
            {
                ISingleOperation calculator = SingleOperationFactory.Create(name);
                resultField.Text = calculator.Calculation(Convert.ToDouble(firstArgument.Text)).ToString();
            }
        }
        private void multiplycationf_Click(object sender, EventArgs e)
        {
            Calculate("*");
        }

        private void divisionButton_Click(object sender, EventArgs e)
        {
            Calculate("/");
        }

        private void additionButton_Click(object sender, EventArgs e)
        {
            Calculate("+");
        }

        private void substractionButton_Click(object sender, EventArgs e)
        {
            Calculate("-");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SCalculate("ln");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SCalculate("sin");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SCalculate("arccos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SCalculate("cubes");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SCalculate("tan");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Calculate("pow");
        }
    }
}


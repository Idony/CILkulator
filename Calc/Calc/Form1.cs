using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Calculate(string name)
        {
            IBinaryOperation calculator = BinaryOperationFactory.Create(name);
            if (firstArgument.Text != "" && secondArgument.Text!="") resultField.Text = calculator.Calculation(Convert.ToDouble(firstArgument.Text), Convert.ToDouble(secondArgument.Text)).ToString();
        }
        private void SCalculate(string name)
        {
            ISingleOperation calculator = SingleOperationFactory.Create(name);
            if (firstArgument.Text != "") resultField.Text = calculator.Calculation(Convert.ToDouble(firstArgument.Text)).ToString();
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

        private void SquareClick(object sender, EventArgs e)
        {
            SCalculate("X^2");
        }

        private void Sqrt(object sender, EventArgs e)
        {
            SCalculate("Sqrt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate("x^y");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SCalculate("Ln");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SCalculate("Sin");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SCalculate("Tan");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SCalculate("n!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SCalculate("X^3");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Calculate("x^(1/y)");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SCalculate("Sqrt3");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Calculate("Log");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Calculate("%");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Calculate("EXP");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SCalculate("lg");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SCalculate("arctg");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SCalculate("arcsin");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SCalculate("ctg");
        }




     
    }
}


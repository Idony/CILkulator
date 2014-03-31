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
            resultField.Text = calculator.Calculation(Convert.ToDouble(firstArgument.Text), Convert.ToDouble(secondArgument.Text)).ToString();
        }
        private void SCalculate(string name)
        {
            ISingleOperation calculator = SingleOperationFactory.Create(name);
            resultField.Text = calculator.Calculation(Convert.ToDouble(firstArgument.Text)).ToString();
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




     
    }
}


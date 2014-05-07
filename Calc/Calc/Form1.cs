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
using Calc.Sorts;
using Microsoft.Win32;

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

        private void Calculate(object sender, EventArgs e)
        {

            IBinaryOperation calculator = BinaryOperationFactory.Create(((Button)sender).Text);
            if (firstArgument.Text != "" && secondArgument.Text!="") resultField.Text = calculator.Calculation(Convert.ToDouble(firstArgument.Text), Convert.ToDouble(secondArgument.Text)).ToString();
        }
        private void SCalculate(object sender, EventArgs e)
        {
            ISingleOperation calculator = SingleOperationFactory.Create(((Button)sender).Text);
            if (firstArgument.Text != "") resultField.Text = calculator.Calculation(Convert.ToDouble(firstArgument.Text)).ToString();
        }
 private void SortCalculate(object sender, EventArgs e)
        {
            ISort sort = SortOperationFactory.Create(((Button)sender).Text);
            resultField.Text = sort.Sort(firstArgument.Text);
        }
    }
}


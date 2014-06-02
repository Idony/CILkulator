using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Calc.BinaryCalculators;
using Calc.SingleCalculators;
using Calc.Sorts;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            try
            {
                IBinaryOperation calculator = BinaryOperationFactory.Create(((Button) sender).Text);
                if (firstArgument.Text != "" && secondArgument.Text != "")
                {
                    double doubleFirstArgument = Convert.ToDouble(firstArgument.Text);
                    double doubleSecondArgument = Convert.ToDouble(secondArgument.Text);
                    resultField.Text = calculator.Calculation(doubleFirstArgument, doubleSecondArgument).ToString();
                }
            }
            catch (Exception exception)
            {
                resultField.Text = exception.Message;
            }
        }

        private void SimpleCalculate(object sender, EventArgs e)
        {
            double doubleFirstArgument = Convert.ToDouble(firstArgument.Text);
            try
            {
                ISingleOperation calculator = SingleOperationFactory.Create(((Button) sender).Text);
                if (firstArgument.Text != "")
                {
                    resultField.Text = calculator.Calculation(doubleFirstArgument).ToString();
                }
            }
            catch (Exception exception)
            {
                resultField.Text = exception.Message;
            }
        }

        private void SortCalculate(object sender, EventArgs e)
        {
            try
            {
                ISort sort = SortOperationFactory.Create(((Button) sender).Text);
                List<string> perList = (firstArgument.Text).Split(' ').ToList();
                List<int> per = perList.Select(l => Convert.ToInt32(l)).ToList();
                sort.Sort(per);
                resultField.Text = string.Join(" ", per);
            }
            catch (Exception exception)
            {
                resultField.Text = exception.Message;
            }
        }
    }
}


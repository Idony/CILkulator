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
           
            try
            {
                IBinaryOperation calculator = BinaryOperationFactory.Create(((Button) sender).Text);
                if (firstArgument.Text != "" && secondArgument.Text != "")
                {
                    double DoubleFirstArgument = Convert.ToDouble(firstArgument.Text),
               DoubleSecondArgument = Convert.ToDouble(secondArgument.Text);
                    resultField.Text =
                        calculator.Calculation(DoubleFirstArgument,
                            DoubleSecondArgument).ToString();
                }
            }
            catch (Exception exception)
            {
                resultField.Text = exception.Message;
            }
            
        }

        private void SimpleCalculate(object sender, EventArgs e)
        {
            double DoubleFirstArgument = Convert.ToDouble(firstArgument.Text);
            try
            {
                ISingleOperation calculator = SingleOperationFactory.Create(((Button) sender).Text);
                if (firstArgument.Text != "")
                    resultField.Text = calculator.Calculation(DoubleFirstArgument).ToString();
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


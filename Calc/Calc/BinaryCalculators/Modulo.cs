using System;

namespace Calc.BinaryCalculators
{
    public class Modilo : IBinaryOperation
    {
        public double Calculation(double firstArgument, double secondArgument)
        {
            double result = firstArgument / secondArgument - (int)(firstArgument / secondArgument);
            return result;
        }
    }
}

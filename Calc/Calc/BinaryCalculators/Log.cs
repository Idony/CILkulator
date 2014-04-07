using System;

namespace Calc.BinaryCalculators
{
    public class Log: IBinaryOperation
    {
        public double Calculation(double firstArgument, double secondArgument)
        {
            double result = Math.Log( firstArgument , secondArgument);
            return result;
        }
    }
}

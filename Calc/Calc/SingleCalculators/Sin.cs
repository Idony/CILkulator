using System;

namespace Calc.SingleCalculators
{
    public class Sin : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = Math.Sin(firstArgument);
            return result;
        }

    }
}

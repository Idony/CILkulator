using System;

namespace Calc.SingleCalculators
{
    public class Sqrt : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = Math.Sqrt(firstArgument);
            return result;
        }
    }
}


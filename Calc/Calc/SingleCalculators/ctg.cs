using System;

namespace Calc.SingleCalculators
{
    internal class Ctg : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = 1 / Math.Tan(firstArgument);
            return result;
        }
    }
}

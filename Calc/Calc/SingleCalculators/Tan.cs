using System;

namespace Calc.SingleCalculators
{
    public class Tan : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = Math.Tan(firstArgument);
            return result;
        }
    }
}

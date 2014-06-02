using System;

namespace Calc.SingleCalculators
{
    class arctg : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = Math.Atan(firstArgument);
            return result;
        }
    }
}

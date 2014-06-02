using System;

namespace Calc.SingleCalculators
{
    class Arctg : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = Math.Atan(firstArgument);
            return result;
        }
    }
}

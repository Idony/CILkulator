using System;

namespace Calc.SingleCalculators
{
    class arcctg : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = Math.PI/2-Math.Atan(firstArgument);
            return result;
        }
    }
}
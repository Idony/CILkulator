using System;

namespace Calc.SingleCalculators
{
    class cos : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = Math.Cos(firstArgument);
            return result;
        }
    }
}

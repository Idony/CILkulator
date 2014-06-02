using System;

namespace Calc.SingleCalculators
{
    class ctg : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = 1/Math.Tan(firstArgument);
            return result;
        }
    }
}

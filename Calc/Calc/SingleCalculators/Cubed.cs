using System;

namespace Calc.SingleCalculators
{
    public class Cubed : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = Math.Pow(firstArgument, 3.0);
            return result;
        }
    }
}

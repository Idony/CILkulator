using System;

namespace Calc.SingleCalculators
{
    public class Sqrt3 : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {

            double result = Math.Pow(firstArgument, 1.0/3.0);
            return result;
        }
    }
}


using System;

namespace Calc.BinaryCalculators
{
    public class Power : IBinaryOperation
    {
        public double Calculation(double firstArgument, double secondArgument)
        {
            double result = Math.Pow(firstArgument, secondArgument);
            return result;
        }
    }
}

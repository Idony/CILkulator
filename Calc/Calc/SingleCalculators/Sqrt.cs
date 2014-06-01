using System;

namespace Calc.SingleCalculators
{
    public class Sqrt : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new ArgumentException("Ошибка вводимых данных", "firstArgument");
            }
            double result = Math.Sqrt(firstArgument);
            return result;
        }
    }
}


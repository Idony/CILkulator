using System;

namespace Calc.SingleCalculators
{
    internal class Lg : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            if (firstArgument <= 0 || (firstArgument == 1))
            {
                throw new ArgumentException("Ошибка вводимых данных", "firstArgument");
            }
            double result = Math.Log10(firstArgument);
            return result;
        }
    }
}

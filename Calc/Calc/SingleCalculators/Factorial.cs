using System;

namespace Calc.SingleCalculators
{
    public class Factorial : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new ArgumentException("Ошибка вводимых данных", "firstArgument");
            }
            double result = 1;
            for (int i = 1; i <= firstArgument; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}

using System;

namespace Calc.SingleCalculators
{
    class arcsin : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            if (firstArgument < -1 || firstArgument > 1)
            {
                throw new ArgumentException("Ошибка вводимых данных", "firstArgument");
            }
            double result = Math.Asin(firstArgument);
            return result;
        }
    }
}

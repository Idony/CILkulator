using System;

namespace Calc.SingleCalculators
{
    class Delx : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            if (firstArgument == 0)
            {
                throw new ArgumentException("Ошибка вводимых данных", "firstArgument");
            }
            double result = 1/(firstArgument);
            return result;
        }
    }
}

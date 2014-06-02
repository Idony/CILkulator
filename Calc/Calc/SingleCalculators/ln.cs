using System;

namespace Calc.SingleCalculators
{
    public class Ln : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            if (firstArgument <= 0)
            {
                throw new ArgumentException("Ошибка вводимых данных", "firstArgument");
            }
            double result = Math.Log(firstArgument, Math.E);
            return result;
        }
    }
}


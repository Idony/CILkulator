using System;

namespace Calc.BinaryCalculators
{
    public class Log : IBinaryOperation
    {
        public double Calculation(double firstArgument, double secondArgument)
        {
            if (secondArgument < 0 || firstArgument < 0 || secondArgument == 1)
            {
                throw new ArgumentException("Ошибка вводимых данных", "firstArgument and secondArgument");
            }
            double result = Math.Log(firstArgument, secondArgument);
            return result;
        }
    }
}

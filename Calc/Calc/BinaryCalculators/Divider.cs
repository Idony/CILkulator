using System;

namespace Calc.BinaryCalculators
{
    public class Divider : IBinaryOperation
    {
        public double Calculation(double firstArgument, double secondArgument)
        {
            if (secondArgument==0)
            {
                throw new ArgumentException("Ошибка вводимых данных", "secondArgument");
            }
            double result = firstArgument / secondArgument;
            return result;
        }
    }
}

using System;

namespace Calc.BinaryCalculators
{
    public class Modilo : IBinaryOperation
    {
        public double Calculation(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new ArgumentException("Ошибка вводимых данных", "secondArgument");
            }
            double result =( firstArgument / secondArgument - (int)(firstArgument / secondArgument))*secondArgument;
            return result;
        }
    }
}

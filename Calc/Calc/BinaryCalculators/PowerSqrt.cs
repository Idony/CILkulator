using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.BinaryCalculators
{
    public class PowerSqrt : IBinaryOperation
    {
        public double Calculation(double firstArgument, double secondArgument)
        {
            if (secondArgument ==0)
            {
                throw new ArgumentException("Ошибка вводимых данных", "secondArgument");
            }
            double result = Math.Pow( firstArgument,1.0/secondArgument);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.SingleCalculators
{
    public class Ln : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            if (firstArgument > 0 && firstArgument!=1)
            {
                throw new ArgumentException("Ошибка вводимых данных", "firstArgument");
            }
            double result = Math.Log(firstArgument,Math.E);
            return result;
        }
    }
}


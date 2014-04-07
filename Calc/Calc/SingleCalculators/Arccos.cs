using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.SingleCalculators
{
    class Arccos : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = Math.Acos(firstArgument);
            return result;
        }
    }
}

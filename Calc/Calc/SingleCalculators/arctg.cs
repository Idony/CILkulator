using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.SingleCalculators
{
    class arctg : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = Math.Atan(firstArgument);
            return result;
        }
    }
}

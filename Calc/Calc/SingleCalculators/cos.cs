using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.SingleCalculators
{
    class cos : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = Math.Cos(firstArgument);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.SingleCalculators
{
    class delx : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = 1/(firstArgument);
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.SingleCalculators
{
    class swap : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = (firstArgument)*(-1);
            return result;
        }
    }
}

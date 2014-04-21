using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.SingleCalculators
{
    class ctg : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = 1/Math.Tan(firstArgument);
            return result;
        }
    }
}

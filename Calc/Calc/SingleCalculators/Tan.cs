using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.SingleCalculators
{
    public class Tan : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = Math.Tan(firstArgument);
            return result;
        }
    }
}

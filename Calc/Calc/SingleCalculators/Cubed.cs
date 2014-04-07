using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.SingleCalculators
{
    public class Cubed : ISingleOperation
    {
        public double Calculation(double firstArgument)
        {
            double result = Math.Pow(firstArgument, 3.0);
            return result;
        }
    }
}

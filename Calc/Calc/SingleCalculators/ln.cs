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
            double result = Math.Log(firstArgument,Math.E);
            return result;
        }
    }
}


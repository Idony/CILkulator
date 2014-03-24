using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.BinaryCalculators
{
    public interface IBinaryOperation
    {
        double Calculation(double firstArgument, double secondArgument);
    }
}

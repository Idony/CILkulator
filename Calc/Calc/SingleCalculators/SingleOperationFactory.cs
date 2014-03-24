using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.SingleCalculators
{
    public static class SingleOperationFactory
    {
        public static ISingleOperation Create(string calculatorName)
        {
            switch (calculatorName)
            {
                case "":
                   // return new Adder();
                default:
                    throw new ArgumentException("ПИШИ ПРАВИЛЬНО УВАСЯ!!", "calculatorName");

            }
        }
    }
}

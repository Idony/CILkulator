using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
                case "X^2":
                   return new Square();
                case "Sqrt":
                   return new Sqrt();
                case "Arccos":
                    return new Arccos();
                case "Tan":
                    return new Tan();
                case "Sin":
                    return new Sin();
                case "Ln":
                    return new Ln();
                case "x^3":
                    return new Cubed();
                case "n!":
                    return new Factorial();
                case "X^3":
                    return new Cubed();
                case "Sqrt3":
                    return new Sqrt3();
                case "lg":
                    return new lg();
                default:
                    throw new ArgumentException("ПИШИ ПРАВИЛЬНО УВАСЯ!!", "calculatorName");

            }
        }
    }
}

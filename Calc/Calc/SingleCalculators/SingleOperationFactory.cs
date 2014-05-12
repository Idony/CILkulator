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
                case "x^2":
                   return new Square();
                case "sqrt":
                   return new Sqrt();
                case "arccos":
                    return new Arccos();
                case "tan":
                    return new Tan();
                case "sin":
                    return new Sin();
                case "ln":
                    return new Ln();
                case "x^3":
                    return new Cubed();
                case "n!":
                    return new Factorial();
                case "sqrt^3":
                    return new Sqrt3();
                case "lg":
                    return new lg();
                case "arctg":
                    return new arctg();
                case "arcsin":
                    return new arcsin();
                case "ctg":
                    return new ctg();
                case "arcctg":
                    return new arcctg();
                case "Arccos":
                    return new Arccos();
                case "1/x":
                    return new delx();
                case "cos":
                    return new cos();
                case "+/-":
                    return new swap();
                default:
                    throw new ArgumentException("ПИШИ ПРАВИЛЬНО УВАСЯ!!", "calculatorName");

            }
        }
    }
}

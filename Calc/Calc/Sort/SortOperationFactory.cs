using System;
namespace Calc.Sort
{
    public static class SortOperationFactory
    {
        public static ISort Create(string calculatorName)
        {
            switch (calculatorName)
            {
                case "qsort":
                    return new QSort();
                default:
                    throw new ArgumentException("ПИШИ ПРАВИЛЬНО УВАСЯ!!", "calculatorName");

            }
        }
    }
}

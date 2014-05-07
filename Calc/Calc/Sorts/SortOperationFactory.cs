using System;

namespace Calc.Sorts
{
    public static class SortOperationFactory
    {
        public static ISort Create(string calculatorName)
        {
            switch (calculatorName)
            {
                case "qsort":
                    return new QSort();
                case "InsertionSort":
                    return new InsertionSort();
                case "Pozyrek":
                    return new Pozyrek();
                default:
                    throw new ArgumentException("ПИШИ ПРАВИЛЬНО УВАСЯ!!", "calculatorName");

            }
        }
    }
}

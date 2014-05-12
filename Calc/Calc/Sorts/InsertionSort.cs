using System;
using System.Collections.Generic;
using System.Linq;

namespace Calc.Sorts
{
    public class InsertionSort : ISort
    {
        public string Sort(string firstArgument)
        {
            List<string> perList=firstArgument.Split(' ').ToList();
            List<int> per = perList.Select(l => Convert.ToInt32(l)).ToList();
            for (int i = 1; i < per.Count; i++)
                for (int j = i; j > 0 && per[j - 1] > per[j]; j--) // пока j>0 и элемент j-1 > j, x-массив int
                {
                    int t=per[j - 1];
                    per[j - 1] = per[j];
                    per[j] = t;
                } 
             

            return string.Join(" ", per);
        }
    }
}

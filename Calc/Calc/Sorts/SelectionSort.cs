using System.Collections.Generic;

namespace Calc.Sorts
{
    public class SelectionSort : ISort
    {
        public List<int> Sort(List<int> per)
        {
            for (int i = 0; i < per.Count - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < per.Count; j++)
                {
                    if (per[j] < per[min])
                    {
                        min = j;
                    }
                }
                int dummy = per[i];
                per[i] = per[min];
                per[min] = dummy;
            }
            return per;
        }
    }
}

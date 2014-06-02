using System.Collections.Generic;

namespace Calc.Sorts
{
    public class QSort : ISort
    {
        public List<int> Sort(List<int> a)
        {
            a.Sort();
            return a;
        }
    }
}

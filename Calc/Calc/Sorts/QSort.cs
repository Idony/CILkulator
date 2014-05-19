using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

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

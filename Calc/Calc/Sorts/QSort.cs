using System;
using System.Collections.Generic;
using System.Linq;

namespace Calc.Sorts
{
    public class QSort : ISort
    {
        public string Sort(string firstArgument)
        {
            List<string> perList=firstArgument.Split(' ').ToList();
            List<int> per = perList.Select(l => Convert.ToInt32(l)).ToList();
            per.Sort();
            return string.Join(" ", per);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace Calc.Sort
{
    public class QSort : ISort
    {
        public string Sort(string firstArgument)
        {
            List<string> perList=firstArgument.Split(' ').ToList();
            List<int> per = perList.Select(l => Convert.ToInt32(l)).ToList();
            per.Sort(Comp);
            return string.Join(" ", per);
        }
        private int Comp(int a, int b)
        {
            return a > b ? 0 : 1;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Calc.Sorts
{
    public class Pozyrek : ISort
    {
        public string Sort(string firstArgument)
        {
            List<string> perList=firstArgument.Split(' ').ToList();
            List<int> per = perList.Select(l => Convert.ToInt32(l)).ToList();
            for(int i=0;i<per.Count-1;i++)
                for (int j = 0; j < per.Count - i-1; j++)
                {
                    if (per[j] > per[j + 1])
                    {
                        int swap = per[j];
                        per[j] = per[j + 1];
                        per[j + 1] = swap;
                    }
                }
            return string.Join(" ", per);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Calc.Sorts
{
    public class MSort : ISort
    {
        public string Sort(string firstArgument)
        {
            List<string> perList=firstArgument.Split(' ').ToList();
            List<int> per = perList.Select(l => Convert.ToInt32(l)).ToList();
            //sort
            return string.Join(" ", per);
        }
    }
}

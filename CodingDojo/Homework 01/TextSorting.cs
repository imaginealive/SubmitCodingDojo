﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    public class TextSorting : ITextSorting
    {
        public string SortByAlphabetical(string text)
        {
            var textArray = text.Split(',');
            Array.Sort(textArray);
            return string.Join(",", textArray);
        }
    }
}
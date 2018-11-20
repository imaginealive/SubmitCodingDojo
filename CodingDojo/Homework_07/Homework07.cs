﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework_07
{
    public class Homework07 : IHomework07
    {
        public string RemoveAndSortTextByAlphabetical(string text)
        {
            var textArray = text.Split(" ");
            var distinctTexts = textArray.Distinct().ToArray();
            Array.Sort(distinctTexts);
            return string.Join(" ", distinctTexts);
        }
    }
}
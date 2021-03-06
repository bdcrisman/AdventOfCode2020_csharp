﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Day6
{
    public class PartOne
    {
        public int SumAnyoneYesAnswers(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            var lines = input.Split(Environment.NewLine).ToList();
            var l = new List<string>();
            var sum = 0;

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    sum += SumAnswers(l);
                    l.Clear();
                    continue;
                }
                l.Add(line.Trim());
            }

            // sum remaining lines
            if (l.Count > 0)
                sum += SumAnswers(l);

            return sum;
        }

        private int SumAnswers(List<string> lines)
        {
            if (lines == null || lines.Count <= 0)
                return 0;

            return string.Join("", lines).Distinct().Count();
        }
    }
}

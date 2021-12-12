using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class RomanToIntSolution
    {
        public int RomanToInt(string s)
        {
            Dictionary<string, int> romanValueToInt = new Dictionary<string, int>
            {
                { "I", 1 }, { "IV", 4 }, { "V", 5 }, { "IX", 9 }, { "X", 10 }, { "XL", 40 },
                { "L", 50 }, { "XC", 90 }, { "C", 100 }, { "CD", 400 }, { "D", 500 }, { "CM", 900 },
                { "M", 1000 }
            };

            int number = 0;

            for (int i=0; i < s.Length; i++)
            {
                if ( (i+1) < s.Length && romanValueToInt.ContainsKey(s[i].ToString() + s[i + 1].ToString()))
                {
                    number = number + romanValueToInt[(s[i] + s[i + 1].ToString())];
                    i++;
                } else
                {
                    number = number + romanValueToInt[s[i].ToString()];
                }
            }

            return number;

        }
    }
}

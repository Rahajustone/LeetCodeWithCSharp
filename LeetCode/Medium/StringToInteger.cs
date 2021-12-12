using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public class StringToInteger
    {
            public int MyAtoi(string s)
            {
                if ((int)s[0] > 64 && (int)s[0] < 123) return 0;

                long res = 0;
                bool flag = false;

                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '-') flag = true;

                    if (s[i] != ' ' && ((int)s[i] > 47 && (int)s[i] < 58))
                    {
                        res = res*10 + CharToInt(s[i]);
                    }
                }

                if (res < Int32.MinValue) res = Int32.MinValue;
                if (res > Int32.MaxValue) res = Int32.MaxValue;

                if (flag) res *= -1;

                return (int)res;
            }

            public int CharToInt(char c)
            {
                List<char> numberToChar = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

                if (numberToChar.Contains(c)) return numberToChar.IndexOf(c);

                return -1;
            }

    }
}

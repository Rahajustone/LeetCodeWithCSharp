using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public class LongestPalindromicSubstringSolution
    {

        private int resultStart;
        private int resultLength;

        public string LongestPolindromWinSlide(string str)
        {
            int strLength = str.Length;

            if (strLength < 2) return str;

            for (int i = 0; i < str.Length; i++)
            {
                LongestPolindromString(str, i, i);
                LongestPolindromString(str, i, i+1);

            }

            return str.Substring(resultStart, resultLength);
        }

        

        public void LongestPolindromString(string str, int start, int end)
        {
            while(start >=0 && end < str.Length && str[start] == str[end])
            {
                start--;
                end++;
            }

            if(resultLength < end -start -1)
            {
                resultStart = start + 1;
                resultLength = end - start - 1;
            }
        }


        // s = "aabc"
        public string LongestPalindrome(string s)
        {
            string longestPolindrom = s[0].ToString();

            for (int i = 0; i < s.Length-1; i++)
            {
                for (int j = i+1; j < s.Length; j++)
                {
                    string substr = s.Substring(i, j-i+1);
                    if ((IsPalindrom(s, i , j) && longestPolindrom.Length < substr.Length))
                    {
                        longestPolindrom = substr;
                    }
                }
            }

            return longestPolindrom;
        }

        public bool IsPalindrom(string str, int start, int end)
        {

            while (start < end)
            {
                if (str[start] != str[end]) return false;

                start++;
                end--;
            }

            return true;
        }

        public bool IsPalindrom(string str)
        {
            int start = 0, end = str.Length - 1;

            while(start < end)
            {
                if (str[start] != str[end]) return false;

                start++;
                end--;
            }

            return true;
        }
    }
}

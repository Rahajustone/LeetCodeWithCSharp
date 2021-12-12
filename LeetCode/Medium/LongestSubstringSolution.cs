using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    class LongestSubstringSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> charHashSet = new HashSet<char>();

            int begin = 0, end = 0;
            int max = 0;
            
            while (end < s.Length)
            {
                if (charHashSet.Contains(s[end]))
                {
                    charHashSet.Remove(s[begin]);
                    ++begin;
                }
                else
                {
                    charHashSet.Add(s[end]);
                    end++;
                }


                if (max < charHashSet.Count) max = charHashSet.Count;
            }

            return max;
        }
    }
}

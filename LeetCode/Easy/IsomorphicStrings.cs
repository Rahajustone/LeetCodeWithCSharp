using System;
using System.Linq;

namespace LeetCode.Easy
{
	public class IsomorphicStrings
	{
        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;
            Dictionary<char, int> dictOne = new Dictionary<char, int>();
            Dictionary<char, int> dictTwo = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dictOne.ContainsKey(s[i]))
                {
                    ++dictOne[s[i]];
                }
                else
                {
                    dictOne.Add(s[i], 1);
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (dictTwo.ContainsKey(t[i]))
                {
                    ++dictTwo[t[i]];
                }
                else
                {
                    dictTwo.Add(t[i], 1);
                }
            }


            return dictOne.Count == dictTwo.Count;

        }
    }
}


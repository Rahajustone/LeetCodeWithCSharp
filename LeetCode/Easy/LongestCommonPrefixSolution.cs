using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class LongestCommonPrefixSolution
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            //Input: strs = ["flower", "flow", "flight"]
            //Output: "fl"

            StringBuilder longestCommonStr = new StringBuilder();
            if (strs == null || strs.Length == 0) return longestCommonStr.ToString();

            // Get the shortest string in the arr
            int min = strs[0].Length;
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length < min)
                    min = strs[i].Length;
            }

            string res = "";
            for (int i = 0; i < min; i++)
            {
                char tempChar = strs[0][i];

                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j][i] != tempChar)
                        return longestCommonStr.ToString();
                }

                longestCommonStr.Append(tempChar);
            }

            return longestCommonStr.ToString();
        }

    }
}

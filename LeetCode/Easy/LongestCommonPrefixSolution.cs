using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            //Input: strs = ["flower", "flow", "flight"]
            //Output: "fl"

            // Get the shortest string in the arr
            int min = 0;
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length > min)
                    min = strs[i].Length;
            }

            string res = "";
            for (int i = 0; i < min; i++)
            {



            }

            return "TODO";
        }

    }
}

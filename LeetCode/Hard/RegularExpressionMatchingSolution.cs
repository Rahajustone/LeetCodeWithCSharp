using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Hard
{
    class RegularExpressionMatchingSolution
    {
        public bool IsMatch(string s, string p)
        {

            string temp = "";
            for (int i = 0; i < p.Length; i++)
            {
                if(p[i] == '*' || p[i] == '.')
                {
                    if (!IsMatchTwoString(temp, p)) return false;

                    temp = "";
                }

                temp += p[i];
            }

            return true;
        }


        public bool IsMatchTwoString(string s, string subStr) => s.Contains(subStr);



    }
}

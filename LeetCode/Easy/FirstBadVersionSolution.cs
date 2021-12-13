using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class FirstBadVersionSolution
    {
        public static bool IsBadVersion(int m)
        {
            return true;
        }
        public static int FirstBadVersion(int n)
        {
            int start = 0;
            int finish = n;
            int ans = -1;

            while (start <= finish)
            {
                int m = start + ((finish - start) / 2);
                if (IsBadVersion(m))
                {
                    finish = m - 1;
                    ans = m;
                }
                else
                    start = m + 1;
            }

            return ans;
        }
    }
}

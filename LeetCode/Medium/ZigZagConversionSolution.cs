using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    class ZigZagConversionSolution
    {
        public String Convert(String s, int numRows)
        {
            if (numRows == 1) return s;

            List<StringBuilder> rows = new List<StringBuilder>();
            for (int i = 0; i < Math.Min(numRows, s.Length); i++)
                rows.Add(new StringBuilder());

            int curRow = 0;
            bool goingDown = false;

            for (int i = 0; i < s.Length; i++)
            {
                rows[curRow].Append(s[i]);

                if (curRow == 0 || curRow ==  numRows -1)
                    goingDown = !goingDown;


                curRow += goingDown ? 1 : -1;

            }

            string res = "";
            foreach (var item in rows)
                res += item;

            return res;
        }
    }
}

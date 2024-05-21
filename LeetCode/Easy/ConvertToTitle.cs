using System;
using System.Text;

namespace LeetCode.Easy
{
	public class ConvertToTitle
	{
        public static string ConvertToTitleSolution(int c)
        {
            StringBuilder sol = new StringBuilder();
            while (c > 0)
            {
                int temp = (c - 1) % 26;
                sol.Append((char)('A' + temp));
                c = (c - 1) / 26;
            }
            return sol.ToString().Reverse().ToString();
        }
    }
}


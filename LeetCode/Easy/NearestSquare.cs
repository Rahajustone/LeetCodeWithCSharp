using System;
namespace LeetCode.Easy
{
	public class NearestSquare
	{
        public int MySqrt(int x)
        {
            // check if x < 
            if (x == 0) return 0;
            if (x < 4) return 1;
            if (x == 4) return 2;

            int a = 2;
            int b = x / 4;
            if (b <= a) b *= 2;

            while (a < b)
            {
                long m = (a + b + 1) / 2;
                if (m * m == x) return (int)m;
                else if (m * m > x) b = (int)m - 1;
                else a = (int)m;
            }
            return a;
        }
    }
}


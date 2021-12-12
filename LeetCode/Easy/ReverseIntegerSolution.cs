using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class ReverseIntegerSolution
    {

        // 1234
        // 40 + 3 = 43  
        public int Reverse(int x)
        {

            long rev = 0;
            bool flag = false;

            if (x < 0)
            {
                x = x * -1;
                flag = true;
            }


            while (x != 0)
            {
                rev = (rev * 10) + (x % 10);

                if (Int32.MinValue > rev || Int32.MaxValue < rev) return 0;

                x = (x / 10);
            }

            if (flag) { rev = rev * -1; }

            return (int)rev;
        }
    }
}

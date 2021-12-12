using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Others
{
    class IntegerDecimalOccurrenceSolution
    {
        // 53 occurs in 1953786 at position 2.
        // 78 occurs in 195378678 at positions 4 and 7.
        // 57 does not occur in 153786.
        public int Solution(int A, int B)
        {

            // A or B can not be negative
            // A or B must be with range of 0 and 999-999-999
            if (A < 0 || A > 999999999 || B < 0 || B > 999999999 || A > B) return 0;


            // Change A and B to string to work easyli with them
            string aToStr = A.ToString();
            string bToStr = B.ToString();
            int result = -1;

           // 
            for (int i = 0; i <= bToStr.Length - aToStr.Length; i++)
            {
                if (bToStr.Substring(i, aToStr.Length) == aToStr)
                        result = i;
            }
            
            return result;
        }
    }
}

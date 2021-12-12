using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public class ContainerWithMostWaterSolution
    {
        public static int MaxArea(int[] height)
        {
            // Input: height = [1, 8, 6, 2, 5, 4, 8, 9, 7]
            // Output: 49

            int start = 0;
            int end = height.Length - 1;

            int max = 0;

            while(start < end)
            {
                int tempMin = Math.Min(height[start], height[end]) * (end - start);
                max = max > tempMin ? max : tempMin;
                if (height[start] < height[end])
                    start++;
                else
                    end--;
            }

            return max;
        }
    }
}

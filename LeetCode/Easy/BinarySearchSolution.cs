using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    class BinarySearchSolution
    {
        public static int Search(int[] nums, int target)
        {
            int start = 0;
            int finish = nums.Length - 1;
            while (start <= finish)
            {
                int median =  (finish + start) / 2;
                if (nums[median] > target)
                    finish = median - 1;
                else if (nums[median] < target)
                    start = median + 1;
                else if (nums[median] == target)
                    return median;
            }

            return -1;
        }
    }
}

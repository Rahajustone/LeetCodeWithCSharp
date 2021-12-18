using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    class RemoveDuplicatesFromSortedArraySolution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }

            return i + 1;
        }
    }
}

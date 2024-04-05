using System;
using System.Collections.Generic;

namespace LeetCode.Easy
{
	public class FindTargetIndicesAfterSortingArray
	{
        public IList<int> TargetIndices(int[] nums, int target)
        {
            var listResult = new List<int>();
            if (nums.Length < 0) return listResult;

            Array.Sort(nums);

            int left = 0;
            int right = nums.Length-1;

            while (left < right)
            {
                int median = (left + right);
                if (nums[median] == target )
                {
                    listResult.Add(median);
                } else if(nums[median] > target)
                {
                    right = median - 1;
                } else
                {
                    left = median + 1;
                }

            }

            return listResult;
        }
    }
}


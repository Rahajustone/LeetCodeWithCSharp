using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode.Easy
{
	public class CountPairsSoultion
	{
        public int CountPairsWithSort(IList<int> nums, int target)
        {
            // [-1,0,1,2,3,4] = 4 c = 

            var sortedNums = nums.OrderBy(x => x).ToList();
            int left = 0, right=sortedNums.Count;
            int count = 0;

            while (left<right)
            {
                if (sortedNums[left] + sortedNums[right] < target)
                {
                    count += right - left;
                    left++;
                }else
                {
                    right--;
                }
            }

            return count;
        }

        public int CountPairsWithTwoLoop(IList<int> nums, int target)
        {
            if (nums.Count <= 0) return -1;

            int count = 0;
            for (int i = 0; i < nums.Count - 1; i++)
            {
                for (int j = i + 1; j < nums.Count; j++)
                {
                    if (nums[i] + nums[j] < target)
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}


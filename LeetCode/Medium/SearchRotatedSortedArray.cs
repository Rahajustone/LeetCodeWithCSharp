﻿using System;
namespace LeetCode.Medium
{
	public class SearchRotatedSortedArray
	{
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (mid == target) return mid;

                if (nums[left] <= nums[mid]) {
                    if (nums[left] <= target && target < nums[mid])
                    {
                        right = mid - 1;
                    } else
                    {
                        left = mid + 1;
                    }
                }
                else {
                    if (nums[mid] < target && target <= nums[right])
                    {
                        left = mid +1;
                    }
                    else
                    {
                        right = mid-1;
                    }

                }
            }

            return -1;
        }
    }
}


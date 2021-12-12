using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    // You can return the answer in any order.
    public class TwoSumSolution
    {
        public int[] TwoSumAnotherWay(int[] nums, int target)
        {
            int[] res = new int[2];
            Dictionary<int, int> dics = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
                dics.Add(nums[i], i);

            for(int j = 0; j < nums.Length; j++)
            {
                int tempData = target - nums[j];
                if(dics.ContainsKey(tempData))
                {
                    res[0] = j;
                    res[1] = dics[tempData];
                }
            }

            return res;
        }



        public int[] TwoSum(int[] nums, int target)
        {
            var res = new int[2];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = (i + 1); j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        res[0] = i;
                        res[1] = j;
                    }
                }
            }

            return res;
        }
    }
}

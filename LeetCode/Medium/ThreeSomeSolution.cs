using System;
using System.Collections;
using System.Collections.Generic;
namespace LeetCode.Medium;

public class ThreeSomeSolution
{

    public IList<IList<int>> ThreeSum(int[] nums)
    {

        IList<IList<int>> list = new List<IList<int>>();
        if (nums.Length < 0) return list;

        Array.Sort(nums);
        int start = 0, left, right;

        while (start < nums.Length - 2)
        {
            int target = nums[start] * (-1);
            left = start + 1;
            right = nums.Length - 1;

            while (left < right)
            {

                if (nums[left] + nums[right] > target) --right;
                else if (nums[left] + nums[right] < target) ++left;
                else
                {
                    var res = new List<int>() { nums[start], nums[left], nums[right] };
                    list.Add(res);

                    while (left < right && nums[left] == res[1])
                        ++left;
                    while (left < right && nums[right] == res[2])
                        --right;

                }
            }

            int currentStartNumber = nums[start];
            while (start < nums.Length - 2 && nums[start] == currentStartNumber)
                ++start;
        }

        return list;
    }

}


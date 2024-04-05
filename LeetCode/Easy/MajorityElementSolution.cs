using System;
using System.Collections.Generic;
namespace LeetCode.Easy
{
	public class MajorityElementSolution
	{

        public static int MajorityElement(int[] nums)
        {
            if (nums.Length <= 0) return 0;
            if (nums.Length == 1) return nums[0];

            Dictionary<int,int> elementKey = new Dictionary<int,int>();

            int maxValueElement = 0;
            int key = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (elementKey.ContainsKey(nums[i]))
                {
                    elementKey[nums[i]] +=1;

                    if(elementKey[nums[i]] > maxValueElement)
                    {
                        maxValueElement = elementKey[nums[i]];
                        key = nums[i];
                    }

                } else
                {
                    elementKey.Add(nums[i], 1);
                }
            }

            return key;
        }
    }
}


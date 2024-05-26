using System;
namespace LeetCode.Medium
{
	public class FourSumSolution
	{
       // TODO
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            if (nums.Length < 4) return result;

            Array.Sort(nums);

            int start = 0, left = 1, right = nums.Length - 1;

            int minDistance = int.MaxValue;
            int sum = int.MinValue;

            while (start < nums.Length-2)
            {
                int tempValue = target - nums[start];
                while (left<right)
                {
                    int currentSum = tempValue - (nums[left] + nums[right]);
                    if(currentSum == target)
                    {
                        var temp = new List<int>();
                    }


                }


            }

            return result;
        }
    }
}


using System;
namespace LeetCode.Medium
{
	public class ThreeSomeClosestSolution
	{
        public int ThreeSumClosest(int[] nums, int target)
        {
            if (nums.Length <= 2) return -1;

            // [4,0,5,-5,3,3,0,-4,-5]
            // [-5,-5,-4,0,0,3,3,4,5 ] , (-2)

            // n*O(logn)
            Array.Sort(nums);

            int start = 0, left=1, right=nums.Length-1;

            int minDistance = int.MaxValue;
            int sum = int.MinValue;

            while (start< nums.Length-1)
            {

                while (left<right)
                {
                    int currentSum = nums[start] + nums[left] + nums[right];
                    if (currentSum == target)
                    {
                        return currentSum;
                    }

                    if (currentSum < target)
                        left++;
                    else
                        right--;

                    if (Math.Abs(currentSum - target) < minDistance)
                    {
                        sum = currentSum;
                        minDistance = Math.Abs(currentSum - target);
                    }

                }

                start++;
                left = start + 1;
                right = nums.Length - 1;
            }
            

            return sum;
        }
    }
}


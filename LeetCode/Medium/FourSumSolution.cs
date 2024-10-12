using System;
namespace LeetCode.Medium
{
    public class FourSumSolution
    {
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            if (nums.Length < 4) return result;

            Array.Sort(nums);

            int current = 0;
            int end = nums.Length - 1;

            while (current < nums.Length - 3)
            {

                while (current + 2 < end)
                {
                    int tempValue = nums[current] + nums[end];
                    if (tempValue > target)
                    {
                        end--;
                        continue;
                    }
                    int left = current + 1, right = end - 1;

                    while (left < right)
                    {
                        int currentSum = tempValue + (nums[left] + nums[right]);
                        if (currentSum == target)
                        {
                            result.Add(new List<int> { nums[current], nums[left], nums[right], nums[end] });
                            left++;
                            right--;
                        }
                        else if (currentSum > target)
                        {
                            right--;
                        }
                        else
                        {
                            left++;
                        }
                    }

                    end--;
                }

                current++;
                end = nums.Length - 1;
            }

            return result;
        }
    }
}


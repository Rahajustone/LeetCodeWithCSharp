using System;
namespace LeetCode.Medium
{
    public class FourSumSolution
    {
        public static IList<IList<int>> FourSum(int[] nums, int target)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (nums.Length < 4) return result;

            Array.Sort(nums);

            int left, right;
            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                for (int j = i + 1; j < nums.Length - 2; j++)
                {
                    if (j > i + 1 && nums[j] == nums[j - 1]) continue;

                    left = j + 1;
                    right = nums.Length - 1;
                    long sumTarget = (long)target - nums[j] - nums[i];
                    while (left < right)
                    {
                        long sum = (long)nums[left] + nums[right];
                        if (sum == sumTarget)
                        {
                            result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                            while (left < right && nums[left] == nums[left + 1]) left++;
                            while (left < right && nums[right] == nums[right - 1]) right--;
                            left++;
                            right--;

                        }
                        else if (sum < sumTarget)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }
            }

            return result;
        }
    }
}


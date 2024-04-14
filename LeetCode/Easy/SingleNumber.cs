using System;
namespace LeetCode.Easy
{
	public class SingleNumber
	{
        public static int SingleNumberSolition(int[] nums)
        {
            Dictionary<int, int> numsRepeatTime = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (numsRepeatTime.ContainsKey(nums[i]))
                {
                    numsRepeatTime[nums[i]] += 1;
                } else
                {
                    numsRepeatTime.Add(nums[i], 1);
                }
            }

            foreach (KeyValuePair<int, int> kvp in numsRepeatTime)
            {
                if (kvp.Value == 1) return kvp.Key;
            }

            return -1;
        }
    }
}


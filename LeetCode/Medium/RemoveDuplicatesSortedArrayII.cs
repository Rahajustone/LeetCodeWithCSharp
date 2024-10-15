namespace LEETCODEWITHCSHARP.LeetCode.Easy;

public class RemoveDuplicteSortedArrayII
{
  public int RemoveDuplicates(int[] nums)
  {
    int pointer = 0;

    for (int i = 0; i < nums.Length; i++)
    {
      if (pointer - 2 >= 0 && nums[pointer - 2] == nums[1])
        continue;
      nums[pointer] = nums[i];
      pointer++;
    }

    return pointer;
  }

}
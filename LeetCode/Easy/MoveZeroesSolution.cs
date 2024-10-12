namespace LEETCODEWITHCSHARP.LeetCode.Easy;

public class MoveZeroesSolution
{
  public void MoveZeroes(int[] nums)
  {
    int current = 0;
    int next = current + 1;
    int arrLength = nums.Length;
    while (next < arrLength)
    {
      if (nums[current] == 0 && nums[next] == 0)
      {
        next++;
      }
      else if (nums[current] == 0)
      {
        Swap(nums, current, next);
        current++;
      }
      else
      {
        current++;
        next++;
      }
    }
  }

  public void Swap(int[] nums, int source, int dest)
  {
    int temp = nums[source];
    nums[source] = nums[dest];
    nums[dest] = temp;
  }
}
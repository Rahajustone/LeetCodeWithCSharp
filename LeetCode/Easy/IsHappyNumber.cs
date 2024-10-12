namespace LEETCODEWITHCSHARP.LeetCode.Easy;
public class HappyNumberSolution
{
  public bool IsHappy(int n)
  {
    HashSet<int> temp = new HashSet<int>();
    int slow = n;
    int fast = SumDigits(slow);

    while (slow != 1 && slow != fast)
    {
      if (temp.Contains(fast))
      {
        break;
      }
      else if (!temp.Contains(fast))
      {
        temp.Add(slow);
      }

      slow = SumDigits(slow);
      fast = SumDigits(SumDigits(fast));
    }

    return fast == 1;
  }

  public int SumDigits(int num)
  {
    int sum = 0;
    while (num > 0)
    {
      int tempDigit = num % 10;
      sum += tempDigit * tempDigit;
      num = num / 10;
    }

    return sum;
  }
}
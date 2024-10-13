namespace LEETCODEWITHCSHARP.LeetCode.Easy;
public class DiStringMatchSolution
{
  public int[] DiStringMatch(string s)
  {
    List<int> rest = new List<int>();

    int strLength = s.Length;
    int iPointer = 0;
    int dPointer = strLength;

    for (int i = 0; i < strLength; i++)
    {
      if (s[i] == 'I')
      {
        rest.Add(iPointer);
        iPointer++;
      }
      else if (s[i] == 'D')
      {
        rest.Add(dPointer);
        dPointer--;
      }

      if ((i + 1) == strLength && s[i] == 'D')
      {
        rest.Add(dPointer);
      }
      else if ((i + 1) == strLength && s[i] == 'I')
      {
        rest.Add(iPointer);
      }
    }

    return rest.ToArray();
  }
}
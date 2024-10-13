namespace LEETCODEWITHCSHARP.LeetCode.Easy;

public class IsLongPressedNameSolution
{
  public bool IsLongPressedName(string name, string typed)
  {
    //

    int firstPointer = 0;
    int lastPointer = 0;
    int nameLength = name.Length;
    int typedLength = typed.Length;
    while (firstPointer < nameLength)
    {
      if (lastPointer == typedLength)
        break;

      if (name[firstPointer] == typed[lastPointer])
      {
        var tempChar = name[firstPointer];
        int countSameChar = 0;
        while (firstPointer < nameLength)
        {
          if (tempChar != name[firstPointer])
            break;
          firstPointer++;
          countSameChar++;
        }

        int countChar = 0;
        while (lastPointer < typedLength)
        {
          if (tempChar != typed[lastPointer])
            break;
          lastPointer++;
          countChar++;
        }

        if (countSameChar > countChar) return false;
      }
      else
      {
        return false;
      }
    }

    if (firstPointer == nameLength && lastPointer == typedLength)
      return true;
    return false;
  }


  public bool IsLongPressedNameSecondSolution(string name, string typed)
  {
    //

    int index = 0;
    for (int i = 0; i < typed.Length; i++)
    {
      if (index < name.Length && name[index] == typed[i]) { index++; continue; }
      else if (index > 0 && name[index - 1] == typed[i]) { continue; }
      return false;
    }

    if (index < name.Length) { return false; }
    return true;
  }
}
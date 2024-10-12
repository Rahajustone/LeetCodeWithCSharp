using System.Text;

namespace LEETCODEWITHCSHARP.LeetCode.Easy;
public class ReverseVowelsSolution
{
  public string ReverseVowels(string s)
  {
    int left = 0;
    int right = s.Length - 1;
    StringBuilder str = new StringBuilder(s);

    HashSet<char> vowels = new HashSet<char> { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };

    while (left < right)
    {
      if (vowels.Contains(s[left]) && vowels.Contains(s[right]))
      {
        var t = str[left];
        str[left] = str[right];
        str[right] = t;
        left++;
        right--;
      }
      else if (vowels.Contains(str[left]))
      {
        right--;
      }
      else if (vowels.Contains(str[right]))
      {
        left++;
      }
      else
      {
        left++;
        right--;
      }
    }

    return str.ToString();
  }
}
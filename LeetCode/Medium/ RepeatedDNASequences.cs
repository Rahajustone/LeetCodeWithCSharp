namespace LEETCODEWITHCSHARP.LeetCode.Easy;

public class FindRepeatedDnaSequencesSolution
{

  // Example 1:
  // Input: s = "AAAAACCCCCAAAAACCCCCCAAAAAGGGTTT"
  // Output: ["AAAAACCCCC","CCCCCAAAAA"]
  // Example 2:
  // Input: s = "AAAAAAAAAAAAA"
  // Output: ["AAAAAAAAAA"]
  public IList<string> FindRepeatedDnaSequencesWithMoreOptimal(string dna)
  {
    Dictionary<char, int> dnaCharIntegerPair = new Dictionary<char, int>();
    dnaCharIntegerPair.Add('A', 1);
    dnaCharIntegerPair.Add('C', 1);
    dnaCharIntegerPair.Add('G', 1);
    dnaCharIntegerPair.Add('T', 1);

    // DNA composed of 4 chars
    int baseValue = 4;
    int dnaLength = dna.Length;
    int subStrLength = 10;

    List<int> numbers = new List<int>();
    for (int i = 0; i < dnaLength; i++)
    {
      if (dnaCharIntegerPair.ContainsKey(dna[i]))
        numbers.Add(dnaCharIntegerPair[dna[i]]);
    }

    int firstPointer = 0;
    int hashValue = 0;
    HashSet<int> storeHashedInt = new HashSet<int>();
    IList<string> result = new List<string>();
    while (firstPointer + subStrLength < dnaLength)
    {
      if (firstPointer == 0)
      {
        for (int i = 0; i < subStrLength; i++)
        {
          hashValue += numbers[i] * (int)Math.Pow(baseValue, subStrLength - i - 1);
        }

      }
      else
      {
        int previousHashValue = hashValue;
        hashValue = ((previousHashValue - numbers[firstPointer - 1] * (int)Math.Pow(baseValue, subStrLength - 1)) * baseValue)
          + numbers[firstPointer + subStrLength - 1];
      }

      if (storeHashedInt.Contains(hashValue))
        result.Add(dna.Substring(firstPointer, subStrLength));

      storeHashedInt.Add(hashValue);
    }


    return result;
  }


  public IList<string> FindRepeatedDnaSequences(string dna)
  {
    int k = 10;
    Dictionary<string, int> uniqueSubStr = new Dictionary<string, int>();
    IList<string> commonSubStr = new List<string>();
    int dnaLength = dna.Length;
    if (dnaLength < k)
      return commonSubStr;

    int startPointer = 0;
    while ((startPointer + k) <= dnaLength)
    {
      string tempSubStr = dna.Substring(startPointer, k);
      if (uniqueSubStr.ContainsKey(tempSubStr))
      {
        uniqueSubStr[tempSubStr] += 1;
        if (uniqueSubStr[tempSubStr] == 2)
          commonSubStr.Add(tempSubStr);
      }
      else
        uniqueSubStr.Add(tempSubStr, 1);

      startPointer++;
    }

    return commonSubStr;
  }
}
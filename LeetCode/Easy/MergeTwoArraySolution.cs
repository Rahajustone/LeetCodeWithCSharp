using System.Collections.Generic;

namespace LeetCode.Easy
{
    class MergeTwoArraySolution
    {
        static int[] MergeTwoArray(int[] firstArr, int[] secondArr)
        {
            List<int> tempHashSet = new List<int>();

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (!tempHashSet.Contains(firstArr[i]))
                    tempHashSet.Add(firstArr[i]);
            }

            for (int j = 0; j < secondArr.Length; j++)
            {
                if (!tempHashSet.Contains(secondArr[j]))
                    tempHashSet.Add(secondArr[j]);
            }

            tempHashSet.Sort();
            return tempHashSet.ToArray();
        }

    }
}

using System.Collections.Generic;

namespace LeetCode.Others
{
    class DublicateNumberInTwoArray
    {
        public static int[] FindDublicateNumber(int[] arrOne, int[] arrTwo)
        {
            // if Array one and array two sorted
            int i = 0;
            int j = 0;

            List<int> res = new List<int>();

            while (i < arrOne.Length && j < arrTwo.Length)
            {
                if (arrOne[i] == arrTwo[j])
                {
                    res.Add(arrOne[i]);
                    i++;
                    j++;
                }
                else if (arrOne[i] < arrTwo[j])
                    i++;
                else
                    j++;
            }

            return res.ToArray();
        }
    }
}

using System;
namespace LeetCode.Easy
{
	public class PlusOneSolution
	{
        //Input: digits = [1,2,3]
        //Output: [1,2,4]
        //Explanation: The array represents the integer 123.
        //Incrementing by one gives 123 + 1 = 124.
        //Thus, the result should be[1, 2, 4].

        public int[] PlusOne(int[] digits)
        {
            for (int i = digits.Length-1; i >=0; i++)
            {
                if (digits[i] == 9)
                {
                    digits[i] = 0;
                }
                else
                {
                    digits[i] += 1;
                    return digits;
                }
            }

            int[] newRes = new int[digits.Length + 1];
            newRes[0] = 1;
            return newRes;
        }


        public int[] PlusOneMine(int[] digits)
        {
            var res = digits;
            int i = res.Length - 1;

            if (res[i] + 1 < 10)
            {
                res[i] = res[i] + 1;
                return res;
            } else
            {
                while (res[i]+1 > 9)
                {
                    res[i] = 0;
                    i--;
                    if(i < 0 || (res[i] +1) < 10) {
                        break;
                    }
                }

                if (i >= 0)
                {
                    res[i] = res[i] + 1;
                    return res;
                }
                if( i < 0) {
                    int[] newArray = new int[digits.Length + 1];
                    for (int j = 0; j < newArray.Length; j++)
                    {
                        if(j==0) { newArray[0] = 1; }
                        else
                        {
                            newArray[j] = 0;
                        }
                    }

                    return newArray;
                }

                return res;
            }
        }
    }
}


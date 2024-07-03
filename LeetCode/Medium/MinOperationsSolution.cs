using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    public class MinOperationsSolution
    {
        // [0, 0, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0]
        // [1, 1, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0]
        // [1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0]
        // [1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0]
        // [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 0, 0, 1, 1, 0]
        // [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0]
        // [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 1, 1, 0]
        // [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0]
        // [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0]
        // [1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1]
        //  

        public static int MinOperations(int[] nums)
        {
            //
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count++;
                    nums[i] = 1;
                    if ((i + 2) >= nums.Length)
                        return -1;

                    nums[i + 1] = FlipBinary(nums[i + 1]);
                    nums[i + 2] = FlipBinary(nums[i + 2]);
                }
            }

            return count;
        }


        public static int MinOperationsSlidingWindows(int[] nums)
        {
            //
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count++;
                    nums[i] = 1;
                    if ((i + 2) >= nums.Length)
                        return -1;


                    nums[i + 1] = FlipBinary(nums[i + 1]);
                    nums[i + 2] = FlipBinary(nums[i + 2]);

                }
            }

            return count;
        }



        private static int FlipBinary(int i) => i == 0 ? 1 : 0;
    }
}

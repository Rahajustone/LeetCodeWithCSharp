using System;
namespace LeetCode.Easy
{
	public class NextGreaterElementISolution
	{

        // Input: nums1 = [4,1,2], nums2 = [1,3,4,2]
        // Output: [-1,3,-1]
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            int n = nums2.Length;
            Stack<int> st = new Stack<int>();
            int[] nextGreator = new int[n];

            for (int i = 0; i < n; i++)
            {
                nextGreator[i] = -1;
                while (st.Any() && nums2[st.Peek()] < nums2[i])
                {
                    nextGreator[st.Pop()] = nums2[i];
                }

                st.Push(i);
            }

            int m = nums1.Length;
            Dictionary<int, int> dct = new Dictionary<int, int>();
            int[] answ = new int[m];

            for (int i = 0; i < n; i++)
            {
                dct[nums2[i]] = i;
            }

            for (int i = 0; i < m; i++)
                answ[i] = nextGreator[dct[nums1[i]]];

            return answ;

        }


        // Input: nums1 = [4,1,2], nums2 = [1,3,4,2]
        // Output: [-1,3,-1]
        public int[] NextGreaterElementBruteForce(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length];

            for (int i = 0; i < nums1.Length; i++)
            {
                var nextGreateElement = FindNextGreateElement(nums1[i], nums2);
                result[i] = nextGreateElement;
            }

            return result;
        }

        private int FindNextGreateElement(int target, int[] sourceArr)
        {
            bool flag = false;
            for (int j = 0; j < sourceArr.Length; j++)
            {
                if (target == sourceArr[j])
                    flag = true;

                if (flag && target < sourceArr[j])
                    return sourceArr[j];
            }

            return -1;
        }
    }
}


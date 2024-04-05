using System;
namespace LeetCode.Easy
{
	public class MergeSortedArraySolution
	{
        // nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        public static void MergeSol2(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0) return;

            int endIndex = nums1.Length - 1;
            while (n > 0 && m > 0)
            {
                if (nums2[n-1] >= nums1[m-1]) {
                    nums1[endIndex] = nums2[n-1];
                    n--;
                } else
                {
                    nums1[endIndex] = nums1[m-1];
                    m--;
                }
            }

            while (n>0)
            {
                nums1[endIndex] = nums2[n - 1];
                n--;
                endIndex--;
            }
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            // nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
            int[] newArr = new int[m + n];
            int i = 0, j = 0;
            int index = 0;
            while (index < m+n)
            {
                if(i < m && j < n) {
                    if (nums1[i] < nums2[j])
                    {
                        newArr[index] = nums1[i];
                        i++;
                    }
                    else if (nums1[i] > nums2[j])
                    {
                        newArr[index] = nums2[j];
                        j++;
                    }
                    else
                    {
                        newArr[index++] = nums1[i];
                        newArr[index] = nums2[j];
                        i++;
                        j++;
                    }
                }

                else if (i < m)
                {
                    newArr[index] = nums1[i];
                    i++;
                } else if (j < n)
                {
                    newArr[index] = nums2[j];
                    j++;
                }

                index++;
            }

            for (int k = 0; k < m + n; k++)
            {
                Console.WriteLine(newArr[k]);
            }
        }
    }
}


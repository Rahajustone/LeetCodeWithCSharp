using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Hard
{
    class MedianOfTwoSortedArraysSolution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> newList = new List<int>();

            int maxLength = nums1.Length > nums2.Length ? nums1.Length : nums2.Length;

            int i = 0, j = 0;
            while (i < maxLength)
            {
                if (i >= nums1.Length || j >= nums2.Length) break;
                if (nums1[i] < nums2[j])
                {
                    newList.Add(nums1[i]);
                    i++;
                }
                else if (nums1[i] > nums2[j])
                {
                    newList.Add(nums2[j]);
                    j++;
                } else
                {
                    newList.Add(nums1[i]);
                    newList.Add(nums2[j]);
                    i++;
                    j++;
                }
            }

            for (int l = i; l < nums1.Length; l++)
            {
                newList.Add(nums1[l]);
            }

            for (int k = j; k < nums2.Length; k++)
            {
                newList.Add(nums2[k]);
            }

            int mid = newList.Count;
            double res = 0;
            if (mid % 2 == 0)
            {
                res = (double)(newList[(int)mid / 2] + newList[(int)mid / 2 - 1]) / 2;
            }
            else
            {
                res = newList[mid / 2];
            }

            return res;
        }
    }
}

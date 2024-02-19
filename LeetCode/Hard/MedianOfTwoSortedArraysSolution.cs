using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Hard
{
    public class MedianOfTwoSortedArraysSolutionWithPointers
    {
        public static double FindMedianSortedArraysWithPartion(int[] nums1, int[] nums2)
        {
            if(nums1.Length > nums2.Length)
            {
                int[] temp = nums1;
                nums1 = nums2;
                nums2 = temp;
            }

            int m = nums1.Length;
            int n = nums2.Length;
            int low = 0, high = m;

            while (low <= high)
            {
                int partitionX = (low + high) / 2;
                int partitionY = (m + n + 1) / 2 - partitionX;

                int maxX = (partitionX == 0) ? int.MinValue : nums1[partitionX - 1];
                int maxY = (partitionY == 0) ? int.MinValue : nums2[partitionY - 1];

                int minX = (partitionX == m) ? int.MaxValue : nums1[partitionX];
                int minY = (partitionY == n) ? int.MaxValue : nums2[partitionY];

                if (maxX <= minY && maxY <= minX)
                {
                    if ((m + n) % 2 == 0)
                    {
                        return (Math.Max(maxX, maxY) + Math.Min(minX, minY)) / 2.0;
                    }
                    else
                    {
                        return Math.Max(maxX, maxY);
                    }
                }
                else if (maxX > minY)
                {
                    high = partitionX - 1;
                }
                else
                {
                    low = partitionX + 1;
                }
            }

            throw new ArgumentException("Input arrays are not sorted");
        }

        public static double FindMedianSortedArraysWithBruteForce(int[] nums1, int[] nums2)
        {
            int firstArrLength = nums1.Length;
            int secondArrLength = nums2.Length;
            int mid = firstArrLength + secondArrLength / 2;
            int p1 = 0;
            int p2 = 0;
            int m1 = 0, m2 = 0;

            for (int count = 0; count < mid; count++)
            {
                m2 = m1;
                if (p1 != firstArrLength && p2 != secondArrLength)
                {
                    if (nums1[p1] > nums2[p2])
                    {
                        m1 = nums2[p2++];
                    }
                    else
                    {
                        m1 = nums1[p1++];
                    }
                }
                else if (p1 < firstArrLength)
                {
                    m1 = nums1[p1++];
                }
                else
                {
                    m1 = nums2[p2++];
                }
            }

            if ((firstArrLength + secondArrLength / 2) % 2 == 0)
            {
                return (double)m1;
            }
            else
            {
                double r = (double)m1 + (double)m2;
                return r / 2.0;
            }
        }

        private static void GetTheArray(int[] nums1, int[] nums2, ref int firstPointer, ref int secondPointer, int[] newArray, ref int i)
        {
            if (nums1[firstPointer] < nums2[secondPointer])
            {
                newArray[i++] = nums1[firstPointer++];
            }
            else if (nums1[firstPointer] > nums2[secondPointer])
            {
                newArray[i++] = nums2[secondPointer++];
            }
            else if (nums1[firstPointer] == nums2[secondPointer])
            {
                newArray[i++] = nums1[firstPointer++];
                newArray[i++] = nums2[secondPointer++];
            }
        }

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
                }
                else
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

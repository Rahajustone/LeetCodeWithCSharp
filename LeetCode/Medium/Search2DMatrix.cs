using System;
namespace LeetCode.Medium
{
	public class Search2DMatrix
	{

        // Input: matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3
        // Output: true
        // O(log(m*n))


        public bool SearchMatrix(int[][] matrix, int target)
        {
            int first = 0;
            int last = matrix.Length;

            //int mid = (first + last) / 2; 

            while (first<=last)
            {
                int mid = (first + last) / 2;

                if (matrix[mid][0] > target)
                {
                    last = mid - 1;

                } else if (matrix[mid][(matrix[mid].Length)-1] < target)
                {
                    first = mid + 1;

                } else
                {
                    ExistOrNot(matrix[mid], target);
                }
            }

            return false;
        }

        private bool ExistOrNot(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length-1;

            while (left < right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == target) return true;
                else if (arr[mid] > target) right = mid - 1;
                else if (arr[mid] < target) left = mid + 1;
            }

            return false;
        }
    }
}


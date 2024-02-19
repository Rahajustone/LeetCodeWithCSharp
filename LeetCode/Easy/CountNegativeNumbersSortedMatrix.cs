using System;
namespace LeetCode.Easy
{
	public class CountNegativeNumbersSortedMatrix
	{
        public int CountNegatives(int[][] grid)
        {
            int count = 0;
            for (int i = grid.Length-1; i >=0; i--)
            {
                for (int j = grid[i].Length-1; j >=0; j--)
                {
                    if (grid[i][j] < 0)
                    {
                        count++;
                    } else
                    {
                        break;
                    }
                }
            }

            return count;
        }

        public int CountNegativesAnother(int[][] grid)
        {
            int count = 0;

            if (grid is null || (grid.Length < 1 && grid[0].Length < 1))
                return count;

            int r = 0, c = grid[0].Length - 1;

            while (r < grid.Length && c >= 0)
            {
                if (grid[r][c] < 0)
                {
                    count += grid.Length - r;
                    c--;
                }
                else
                    r++;
            }
            return count;
        }
    }
}


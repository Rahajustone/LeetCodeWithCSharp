using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    internal class FindWinnerCircularGame
    {
        public int FindTheWinner(int n, int k)
        {
            Queue<int> integers = new Queue<int>(Enumerable.Range(1, n));

            int indexCount = 1;
            while (integers.Count > 1) {
                if (indexCount == k)
                {
                    integers.Dequeue();
                    indexCount = 1;
                }
                else
                {
                    indexCount++;
                    integers.Enqueue(integers.Dequeue());
                }
            }

            return integers.Dequeue(); ;
        }
    }
}

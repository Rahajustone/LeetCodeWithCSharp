using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class RecentCounter
    {
        private Queue<int> pintTime = new Queue<int>(3000);
        public RecentCounter()
        {
        }

        public int Ping(int t)
        {
            pintTime.Enqueue(t);
            while (pintTime.Peek() < t -3000)
            {
                pintTime.Dequeue();
            }

            return pintTime.Count;

        }
    }
}

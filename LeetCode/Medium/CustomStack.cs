using System;
namespace LeetCode.Medium
{
	public class CustomStack
	{
        private int[] customStack;
        private int count;
        private int maxSize;
        public CustomStack(int maxSize)
        {
            customStack = new int[maxSize];
            count = -1;
            this.maxSize = maxSize;
        }

        public void Push(int x)
        {
            if (count < maxSize - 1)
            {
                count++;
                customStack[count] = x;
            }

        }

        public int Pop()
        {
            if (count >= 0)
            {
                int res = customStack[count];
                count--;
                return res;
            }

            return -1;
        }

        public void Increment(int k, int val)
        {
            int elementsToIncrement = Math.Min(k, count + 1);
            for (int i = 0; i < elementsToIncrement; i++)
            {
                customStack[i] += val;
            }
        }
    }
}


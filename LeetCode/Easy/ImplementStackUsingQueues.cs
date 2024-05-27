using System;
namespace LeetCode.Easy
{
	public class ImplementStackUsingQueues
	{
        private Queue<int> myFirstQueue;
        private Queue<int> mySecondQueue;
        private int topElement;


        // [1,2,3,4]
        // [2,1]
        // [2,1]

        public ImplementStackUsingQueues()
		{
            myFirstQueue = new Queue<int>();
            mySecondQueue = new Queue<int>();
        }

        public void Push(int x)
        {
            myFirstQueue.Enqueue(x);
            topElement = x;
        }

        public int Pop()
        {
            while (myFirstQueue.Count > 1)
            {
                topElement = myFirstQueue.Dequeue();
                mySecondQueue.Enqueue(topElement);
            }

            int popped = myFirstQueue.Dequeue();
            SwapQueues();

            return popped;
        }

        public int Top()
        {
            return topElement;
        }

        public bool Empty()
        {
            return myFirstQueue.Count == 0;
        }

        private void SwapQueues()
        {
            Queue<int> temp = myFirstQueue;
            myFirstQueue = mySecondQueue;
            mySecondQueue = temp;
        }
    }
}


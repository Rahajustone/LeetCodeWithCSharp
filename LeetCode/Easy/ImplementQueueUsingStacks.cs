using System;
namespace LeetCode.Easy
{
	public class ImplementQueueUsingStacks
	{
        Stack<int> myfirstStack;
        Stack<int> mySecondStack;

        public ImplementQueueUsingStacks()
		{
            myfirstStack = new Stack<int>();
            mySecondStack = new Stack<int>();

        }

        public void Push(int x)
        {
            myfirstStack.Push(x);
        }

        public int Pop()
        {
            CopyToSecondStack();
            return mySecondStack.Pop();
        }

        public int Peek()
        {
            CopyToSecondStack();
            return mySecondStack.Peek();
        }

        public bool Empty()
        {
            return myfirstStack.Count == 0 && mySecondStack.Count == 0;
        }

        private void CopyToSecondStack()
        {
            if (mySecondStack.Count == 0)
            {
                while (myfirstStack.Count > 0)
                {
                    mySecondStack.Push(myfirstStack.Pop());
                }
            }
        }
    }
}

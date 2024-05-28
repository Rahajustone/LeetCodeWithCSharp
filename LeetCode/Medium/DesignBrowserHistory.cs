using System;
namespace LeetCode.Medium
{
	public class DesignBrowserHistory
	{
        Stack<string> forwardSteps;
        Stack<string> backwardSteps;
        private int stepsCount = 0;

        public DesignBrowserHistory(string homepage)
        {
            forwardSteps = new Stack<string>();
            backwardSteps = new Stack<string>();
            forwardSteps.Push(homepage);
        }

        public void Visit(string url)
        {
            forwardSteps.Push(url);

            // clears up all forward history
            while(backwardSteps.Count>0)
            {
                backwardSteps.Pop();
            }
        }

        public string Back(int steps)
        {
            while (steps-- > 0 && forwardSteps.Count > 1)
            {
                backwardSteps.Push(forwardSteps.Pop());
            }

            return forwardSteps.Peek();
        }

        public string Forward(int steps)
        {
            while (steps-- >0 && backwardSteps.Count > 0)
            {
                forwardSteps.Push(backwardSteps.Pop());
            }

            return forwardSteps.Peek();
        }
    }
}


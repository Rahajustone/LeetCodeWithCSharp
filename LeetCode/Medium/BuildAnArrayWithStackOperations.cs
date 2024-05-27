using System;
namespace LeetCode.Medium
{
	public class BuildAnArrayWithStackOperations
	{
		public BuildAnArrayWithStackOperations()
		{
		}


        public IList<string> BuildArray(int[] target, int n)
        {
            IList<string> result = new List<string>();

            int index = 0;
            for (int i = 1; i <= n && index < target.Length; i++)
            {
                if (i == target[index])
                {
                    result.Add("Push");
                    index++;
                }
                else
                {
                    result.Add("Push");
                    result.Add("Pop");
                }
            }

            return result;
        }


        public IList<string> BuildArrayFirsWay(int[] target, int n)
        {
            Stack<int> streamStack = new Stack<int>();
            Stack<string> targetStack = new Stack<string>();
            IList<string> result = new List<string>();
            for (int i = 1; i <= target[target.Length - 1]; i++)
            {
                streamStack.Push(i);
            }

            int targetIndex = target.Length - 1;
            while (streamStack.Count>0)
            {
                if(streamStack.Peek() == target[targetIndex])
                {
                    streamStack.Pop();
                    targetStack.Push("Push");
                    targetIndex--;
                } else
                {
                    streamStack.Pop();
                    targetStack.Push("Pop");
                    targetStack.Push("Push");
                }
            }

            while(targetStack.Count>0) {
                result.Add(targetStack.Pop());
            }

            return result;
        }
    }
}


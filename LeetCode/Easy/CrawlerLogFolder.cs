using System;
namespace LeetCode.Easy
{
	public class CrawlerLogFolder
	{
        public int MinOperations(string[] logs)
        {
            Stack<string> pathFolder = new Stack<string>();

            for (int i = 0; i < logs.Length; i++)
            {
                switch (logs[i])
                {
                    case "../":
                        if (pathFolder.Count > 0)
                            pathFolder.Pop();
                        break;
                    case "./":
                        break;
                    default:
                        pathFolder.Push(logs[i]);
                        break;
                }
            }

            return pathFolder.Count;
        }

        public int MinOperationsSecondSolution(string[] logs) {
            int count = 0;
            for (int i = 0; i < logs.Length; i++)
            {
                if (count > 0 && logs[i] == "../")
                {
                    count--;
                }
                else if (logs[i] != "./" & logs[i] != "../")
                {
                    count++;
                }
            }

            return count < 0 ? 0 : count;
        }

    }
}


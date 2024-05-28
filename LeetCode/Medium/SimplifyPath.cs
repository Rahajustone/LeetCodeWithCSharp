using System;
using System.Text;

namespace LeetCode.Medium
{
	public class SimplifyPath
	{
		public SimplifyPath()
		{
		}

        // Input: path = "/home//foo/"
        // Output: "/home/foo"

        // Input: path = "/home/user/Documents/../Pictures"
        // Output: "/home/user/Pictures"

        public string SimplifyPathSolution(string path)
        {
            string[] pathArr = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
            string resPath = "";

            Stack<string> res = new Stack<string>();

            for (int i = 0; i < pathArr.Length; i++)
            {
                if (pathArr[i] == ".." && res.Count>0)
                {
                    res.Pop();

                }
                else if (pathArr[i] != ".." && pathArr[i] != ".")
                {
                    res.Push(pathArr[i]);
                }
            }

            Stack<string> res2 = new Stack<string>();

            while (res.Count > 0)
            {
                res2.Push(res.Pop());
            }

            while (res2.Count > 0)
            {
                resPath += "/" + res2.Pop();
            }

            return resPath.Length>0? resPath : "/";
        }
    }
}


using System;
using System.Text;

namespace LeetCode.Medium
{
	public class RemovingStarsFromString
	{
		public RemovingStarsFromString()
		{
		}

        public string RemoveStars(string s)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }

            StringBuilder str = new StringBuilder();
            while (stack.Count > 0)
            {
                str.Insert(0, stack.Pop());
            }

            return str.ToString();
        }
    }
}


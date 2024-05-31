using System;
namespace LeetCode.Hard
{
	public class LongestValidParentheses
	{
		public LongestValidParentheses()
		{
		}

        // "()(()"
        public int LongestValidParentheses(string s)
        {
			Stack<char> parenthesis = new Stack<char>();
			int count = 0;
			bool substring = true;
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] == ')' && parenthesis.Count>0)
				{
					parenthesis.Pop();
					count += 2;

                } else if (s[i] == '(')
				{
					substring = true;
					if (count > 0) count = 0;
					parenthesis.Push(s[i]);
				}

			}

			return count;
        }
    }
}


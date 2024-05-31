using System;
namespace LeetCode.Medium
{
	public class MinimumAddMakeParenthesesValid
	{
        public int MinAddToMakeValid(string s)
        {
            Stack<char> paranthes = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    paranthes.Push(s[i]);
                }
                else if (s[i] == ')')
                {
                    if (paranthes.Count > 0 && paranthes.Peek() == '(')
                    {
                        paranthes.Pop();
                    }
                    else
                    {
                        paranthes.Push(s[i]);
                    }
                }
            }

            return paranthes.Count;
        }
    }
}


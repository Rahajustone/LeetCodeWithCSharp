using System;
namespace LeetCode.Easy
{
	public class RemoveOutermostParentheses
	{
        // "((()))"

        public string RemoveOuterParentheses(string s)
        {
            Stack<char> chars = new Stack<char>();
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    if (chars.Count > 0) res += s[i];

                    chars.Push('(');
                }
                else if (s[i] == ')' && chars.Count > 1)
                {
                    chars.Pop();
                    res += s[i];
                }

                else if (s[i] == ')' && chars.Count == 1)
                {
                    chars.Pop();
                }

            }

            return res;
        }

        public string RemoveOuterParenthesesWithoutStack(string s)
        {
            string res = "";
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    if (count > 0) res += s[i];
                    count++;

                }
                else if (s[i] == ')' && count > 1)
                {
                    count--;
                    res += s[i];
                }

                else if (s[i] == ')' && count == 1)
                {
                    count = 0;
                }

            }

            return res;
        }
    }
}


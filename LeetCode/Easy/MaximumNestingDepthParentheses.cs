using System;
namespace LeetCode.Easy
{
	public class MaximumNestingDepthParentheses
	{
        public int MaxDepth(string s)
        {

            Stack<char> chars = new Stack<char>();
            int count = 0;
            int max = int.MinValue;

            // "(1+(2*3)+((8)/4))+1"
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    chars.Push(s[i]);
                    count++;
                }
                if (s[i] == ')')
                {
                    chars.Pop();
                    count--;
                }

                if (max < count) max = count;
            }

            return count;
        }

        public int MaxDepthTwoPointer(string s)
        {

            Stack<char> chars = new Stack<char>();
            int count = 0;
            int max = int.MinValue;

            // "(1+(2*3)+((8)/4))+1"
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    chars.Push(s[i]);
                    count++;
                }
                if (s[i] == ')')
                {
                    chars.Pop();
                    count--;
                }

                if (max < count) max = count;
            }

            return count;
        }
    }
}


using System;
using System.Text;

namespace LeetCode.Medium
{
	public class ReverseParenthesesSolution
	{
		public ReverseParenthesesSolution()
		{
		}

        public string ReverseParentheses(string s)
        {
            Stack<char> reverseStr = new Stack<char>();
            StringBuilder str = new StringBuilder();

            foreach (char c in s)
            {
                if (c != ')')
                {
                    reverseStr.Push(c);
                    continue;
                }

                StringBuilder strTemp = new StringBuilder();
                while (reverseStr.Count > 0 && c == ')')
                {
                    if (reverseStr.Peek() == '(')
                    {
                        reverseStr.Pop();
                        break;
                    }
                    else
                    {
                        var t = reverseStr.Pop();
                        strTemp.Append(t);
                    }
                }


                for (int i = 0; i < strTemp.Length; i++)
                {
                    reverseStr.Push(strTemp[i]);
                }
            }

            var newStack = new Stack<char>();

            while (reverseStr.Count > 0)
            {
                newStack.Push(reverseStr.Pop());
            }

            while (newStack.Count > 0)
            {
                str.Append(newStack.Pop());
            }

            return str.ToString();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public class ValidParenthesesSolution
    {
        public bool IsValid(string s)
        {
            Stack<char> parantheses = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                    parantheses.Push(s[i]);
                else if (s[i] == ')' && parantheses.Count > 0 && parantheses.Peek() == '(')
                    parantheses.Pop();
                else if (s[i] == '}' && parantheses.Count > 0 && parantheses.Peek() == '{')
                    parantheses.Pop();
                else if (s[i] == ']' && parantheses.Count > 0 && parantheses.Peek() == '[')
                    parantheses.Pop();
                else
                    parantheses.Push(s[i]);
            }

            if (parantheses.Count > 0)
                return false;

            return true;
        }
    }
}

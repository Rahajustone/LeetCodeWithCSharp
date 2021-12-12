using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Others
{
    class TestCodality
    {
        public static string solution(string S)
        {
            if (string.IsNullOrEmpty(S) || S.Length > 250000) throw new Exception("String is empty or string length is too large");

            // create stack for char to psuh and pop
            Stack<char> chars = new Stack<char>();

            for (int i = 0; i < S.Length; i++)
            {
                if (chars.Count > 0 && IsAdjacent(chars.Peek().ToString() + S[i].ToString()))
                {
                    chars.Pop();
                }
                else
                {
                    chars.Push(S[i]);
                }
            }

            string res = "";
            for (int i = 0; i < chars.Count; i++)
            {
                res += chars.Pop();
            }

            return Reverse(res);
        }

        private static bool IsAdjacent(string adj)
        {
            // List of character combination
            HashSet<string> adjacents = new HashSet<string> { "AB", "BA", "CD", "DC" };

            return adjacents.Contains(adj);
        }

        public static string solutionSecond(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length > 250000) return String.Empty;
            if (str.Length > 250000 || str.Length < 2) return str;

            int start = 0;
            int next = 1;
            StringBuilder s = new StringBuilder(str);

            // ACACDC
            while (next < s.Length)
            {
                if (((int)s[start] < 65 && (int)s[start] > 69) || ((int)s[next] < 65 && (int)s[next] > 69)) return String.Empty;
                
                int temp = s[start] + s[next];

                if (temp == 131 || temp == 135 && start >= 0)
                {
                    s.Remove(start, 1);
                    s.Remove(next-1, 1);
                    if(start> 0)
                        start--;
                    if(next >1)
                        next--; 
                }
                else
                {
                    start++;
                    next++;
                }
            }

            return s.ToString();
        }

        private static string Reverse(string str)
        {
            string result = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }

            return result;
        }
    }
}

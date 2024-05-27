using System;
namespace LeetCode.Easy
{
	public class BackspaceStringCompare
	{
		public BackspaceStringCompare()
		{
		}

        public bool BackspaceCompare(string s, string t)
        {

            Stack<char> firstStringChars = new Stack<char>();
            Stack<char> secondStringChars = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (firstStringChars.Count > 0 && s[i] == '#') firstStringChars.Pop();
                else if (s[i] != '#') firstStringChars.Push(s[i]);
            }

            for (int j = 0; j < t.Length; j++)
            {
                if (secondStringChars.Count > 0 && t[j] == '#') secondStringChars.Pop();
                else if (t[j] != '#') secondStringChars.Push(t[j]);
            }

            if (firstStringChars.Count != secondStringChars.Count) return false;

            while (firstStringChars.Count > 0)
            {
                if (firstStringChars.Pop() != secondStringChars.Pop()) return false;
            }

            return true;
        }
    }
}


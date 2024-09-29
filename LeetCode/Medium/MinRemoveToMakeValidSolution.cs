using System;
using System.Text;

namespace LeetCode.Medium
{
	public class MinRemoveToMakeValidSolution
	{
		public MinRemoveToMakeValidSolution()
		{
		}

  //      Input: s = "lee(t(c)o)de)"
		//Output: "lee(t(c)o)de"
		//Explanation: "lee(t(co)de)" , "lee(t(c)ode)" would also be accepted.
		//Example 2:

		//Input: s = "a)b(c)d"
		//Output: "ab(c)d"
		//Example 3:

		//Input: s = "))(("

        public string MinRemoveToMakeValid(string s)
		{
			Stack<int> integers = new Stack<int>();
			StringBuilder str = new StringBuilder(s);

			for (int i = 0; i < str.Length; i++)
			{
				if (s[i] == '(')
				{
					integers.Push(i);
				} else
				{
					if(integers.Count>0)
					{
						integers.Pop();
					} else
					{
						str[i] = '*';
					}
				}
			}

			while (integers.Count > 0)
			{
				str[integers.Pop()] = '*';
			}

            StringBuilder finalResult = new StringBuilder();
            foreach (char c in str.ToString())
            {
                if (c != '*')
                    finalResult.Append(c);
            }

            return finalResult.ToString();
        }
	}
}


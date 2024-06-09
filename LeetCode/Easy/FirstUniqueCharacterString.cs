using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class FirstUniqueCharacterString
    {
        // LeetCode
        public int findFirstUnique(string s)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            Queue<int> queue = new Queue<int>();

            for(int i=0;i<s.Length;i++) {
                if (keyValuePairs.ContainsKey(s[i])) {
                    keyValuePairs[s[i]] = keyValuePairs[s[i]] + 1;
                } else
                {
                    keyValuePairs.Add(s[i], 1);
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (keyValuePairs[s[i]] == 1)
                    return i;
            }

            return -1;
        }
    }
}

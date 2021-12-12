using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Medium
{
    class MinimumDeletionsMakeCharacterFrequenciesUnique
    {
        public int MinDeletions(string s)
        {
            // [a=>3, b=>3  c=>2] b = 2, b, c
            int[] charToIntRep = new int[26];

            for (int i = 0; i < s.Length; i++)
            {
                int temp = s[i] - 'a';
                charToIntRep[temp] += 1;
            }

            HashSet<int> set = new HashSet<int>();
            int count = 0;

            for (int i = 0; i < charToIntRep.Length; i++)
            {
                if (charToIntRep[i] == 0) continue;
                if (!set.Contains(charToIntRep[i]))
                {
                    set.Add(charToIntRep[i]);
                } else
                {
                    int temp = 1;
                    while(charToIntRep[i] - temp >0 && set.Contains(charToIntRep[i] - 1))
                    {
                        temp++;
                    }

                    if(charToIntRep[i] - temp > 0)
                    {
                        set.Add(charToIntRep[i] - temp);
                        count += temp;
                    }
                    
                }
            }

            return count;
        }
    }
}

using System;
using System.Linq;
namespace LeetCode.Easy
{
	public class FindIndexFirstOccurrence
	{
        public int StrStr(string haystack, string needle)
        {
            for(int i=0; i<= haystack.Length-needle.Length; i++)
            {
                if((haystack.Substring(i, needle.Length) == needle)){
                    return i;
                }
            }

            return -1;
        }

        public int StrStrTwoPinter(string haystack, string needle)
        {
            if (haystack.Length < needle.Length) return -1;
            int p1 = 0;
            int p2 = 0;

            while (p1 < haystack.Length)
            {
                if (haystack[p1] == needle[p2])
                {
                    p1++;
                    p2++;
                    if (p2 == needle.Length)
                    {
                        return p1 - p2;
                    }
                    else if (p1 < haystack.Length && p2 < needle.Length && haystack[p1] != needle[p2])
                    {
                        p1 = p1 - p2 + 1;
                        p2 = 0;
                    }
                }
                else
                {
                    p1++;
                }
            }

            return -1;
        }
    }
}


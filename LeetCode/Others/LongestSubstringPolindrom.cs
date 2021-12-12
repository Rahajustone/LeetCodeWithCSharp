using System;

namespace LeetCode.Others
{
    class LongestSubstringPolindrom
    {
        private int resulStart;
        private int stringLength;

        public LongestSubstringPolindrom()
        {
            Console.WriteLine(stringLength);
        }


        public string LongestSubstring(string polindromStr)
        {
            // "abbcada"
            // ab

            // string length
            int length = polindromStr.Length;

            // if my string have just one charcter
            // best Option O(1) constant
            if (length < 2) return polindromStr;

            for (int start = 0; start < length; start++)
            {
                ExpandRange(polindromStr, start, start);
                ExpandRange(polindromStr, start, start + 1);
            }

            return polindromStr.Substring(resulStart, stringLength);
        }

        private void ExpandRange(string polindromStr, int begin, int end)
        {
            while (begin >= 0 && end < polindromStr.Length && polindromStr[begin] == polindromStr[end])
            {
                begin--;
                end++;
            }

            // end-begin-1 means my substring length here
            if (stringLength < end - begin - 1)
            {
                resulStart = begin + 1;
                stringLength = end - begin - 1;
            }
        }
    }
}

using System;
using System.Text;

namespace LeetCode.Easy;

public class RemoveAllAdjacentDuplicatesInString
{
    public string RemoveDuplicates(string s)
    {
        StringBuilder st = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (st.Length > 0 && s[i] == st[st.Length - 1])
                st.Remove(st.Length - 1, 1);
            else
                st.Append(s[i]);
        }

        return st.ToString();
    }
}


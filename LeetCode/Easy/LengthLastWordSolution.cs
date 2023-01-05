using System;
namespace LeetCode.Easy
{
	public class LengthLastWordSolution
	{
        public int LengthOfLastWord(string s)
        {
            int count = 0;
            Boolean flag = false;

            //"Hello worlds   "

            for(int i=s.Length-1; i>=0; i--) {
                if (s[i] != ' ')
                {
                    flag = true;
                    count++;

                }
                if (s[i]==' ' && flag)
                    break;
            }

            return count;
        }
    }
}


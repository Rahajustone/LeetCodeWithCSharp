using System;
namespace LeetCode.Easy
{
	public class ValidPalindrome
	{

        public static bool IsPalindromBestSolution(string s)
        {
            int start = 0;
            int end = s.Length - 1;
            s = s.ToLower();
            while (start <= end)
            {
                if (!char.IsLetterOrDigit(s[start]))
                {
                    start++;
                }
                else if (!char.IsLetterOrDigit(s[end]))
                {
                    end--;
                }
                else if (s[start] != s[end])
                {
                    return false;
                }
                else
                {
                    start++;
                    end--;
                }
            }

            return true;
        }

        public static bool IsPalindrome(string s)
        {
            int start = 0;
            int end = s.Length - 1;

            while (start <= end)
            {
                if (((s[start] >= 48 && s[start] <= 57) || (s[start] >= 65 && s[start] <= 90) || (s[start] >= 97 && s[start] <= 122))
                &&
                ((s[end] >= 48 && s[end] <= 57) || (s[end] >= 65 && s[end] <= 90) || (s[end] >= 97 && s[end] <= 122)))
                {
                    if (s[start].ToString().ToLower() != s[end].ToString().ToLower())
                    {
                        return false;
                    }

                    start++;
                    end--;
                }
                else if (((s[start] < 48) || (s[start] > 57 && s[start] < 65) || (s[start] > 90 && s[start] < 97) || (s[start] > 122)))
                {
                    start++;
                }
                else if (((s[end] < 48) || (s[end] > 57 && s[end] < 65) || (s[end] > 90 && s[end] < 97) || (s[end] > 122)))
                {
                    end--;
                }
            }

            return true;
        }

        public bool IsPalindromeManual(string s)
        {
            if (s.Length < 1) return true;
            string newStr = "";
            string newReverseStr = "";
            for (int i = 0; i < s.Length; i++)
            {
                // Capital letter

                if (s[i] >= 48 && s[i] <= 57)
                {
                    newStr += s[i];
                }
                if (s[i] > 64 && s[i] < 91)
                {
                    newStr += (char)(((int)s[i]) + 32);
                }
                // lowercaselater
                if (s[i] >= 97 && s[i] <= 122)
                {
                    newStr += s[i];
                }
            }
            for (int j = newStr.Length - 1; j >= 0; j--)
            {
                newReverseStr += newStr[j];
            }

            return newStr == newReverseStr;
        }
    }
}


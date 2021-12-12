using LeetCode.Easy;
using LeetCode.Hard;
using LeetCode.Medium;
using LeetCode.Others;
using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        public static string ReverseString(string str)
        {
            string res = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                res += str[i];
            }

            return res;
        }

        static void Main(string[] args)
        {
            char[] input = { 'o', 'n', 'e', ' ', ' ', 't', 'w', 'o', ' ', 't', 'h', 'r', 'e', 'e', ' ' };

            string res = "";
            string temp = "";

            for(int i = input.Length-1; i>=0;i-- )
            {
                if(input[i] != ' ')
                {
                    temp = temp + input[i].ToString();
                } else if (input[i] == ' ')
                {
                    res += ReverseString(temp);
                    res += " ";
                    
                    temp = "";
                }
            }

            if (temp.Length > 0)
            {
                res += ReverseString(temp);
            }


            for (var i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}

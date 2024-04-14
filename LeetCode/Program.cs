using LeetCode.Easy;
using LeetCode.Hard;
using LeetCode.Medium;
using LeetCode.Others;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "A man, a plan, a canal: Panama";
            var res = ValidPalindrome.IsPalindrome(str);
            Console.WriteLine(res);
        }

    }
}

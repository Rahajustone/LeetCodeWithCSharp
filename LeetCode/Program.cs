using LeetCode.Easy;
using LeetCode.Hard;
using LeetCode.Medium;
using LeetCode.Others;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    record Test
    {
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This sentence contains both lowercase and uppercase English letters , punctuation marks,and spaces.";

            var res = Solution(text);
            Console.WriteLine(res);

        }


        static string Solution(string text)
        {
            StringBuilder correctedText = new StringBuilder();

            char[] punctuationMarks = { ',', '.', '?', '!' };
            bool lastCharIsPunctuation = false;

            foreach (char c in text)
            {
                if (c == ' ')
                {
                    // Skip consecutive spaces
                    if (correctedText.Length > 0 && correctedText[correctedText.Length - 1] != ' ')
                    {
                        correctedText.Append(c);
                    }
                }
                else if (Array.IndexOf(punctuationMarks, c) != -1)
                {
                    // Ensure no space before punctuation
                    if (correctedText.Length > 0 && correctedText[correctedText.Length - 1] == ' ')
                    {
                        correctedText.Remove(correctedText.Length - 1, 1);
                    }

                    // Add space after punctuation if not last character
                    if (!lastCharIsPunctuation)
                    {
                        correctedText.Append(c);
                        correctedText.Append(' ');
                    }
                    else
                    {
                        correctedText.Append(c);
                    }

                    lastCharIsPunctuation = true;
                }
                else
                {
                    correctedText.Append(c);
                    lastCharIsPunctuation = false;
                }
            }

            return correctedText.ToString();
        }
            



    }
}

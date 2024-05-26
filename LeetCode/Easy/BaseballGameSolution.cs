using System;
using static System.Formats.Asn1.AsnWriter;

namespace LeetCode.Easy
{
	public class BaseballGameSolution
	{
        // ["5","2","C","D","+"]
        public int CalPoints(string[] operations)
        {
            Stack<int> scoreRecords = new Stack<int>();

            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i] ==  "+")
                {
                    var previousScore = scoreRecords.Pop();
                    var previousPScore = scoreRecords.Pop();
                    scoreRecords.Push(previousPScore);
                    scoreRecords.Push(previousScore);
                    scoreRecords.Push(previousScore+previousPScore);
                }
                else if (operations[i] == "D")
                {
                    var previousScore = scoreRecords.Pop();
                    scoreRecords.Push(previousScore);
                    scoreRecords.Push(previousScore * 2);

                } else if (operations[i] == "C")
                {
                    scoreRecords.Pop();
                }
                else
                {
                    scoreRecords.Push(int.Parse(operations[i]));
                }
            }


            int sumRecord = 0;
            int stackLength = scoreRecords.Count;
            for (int i = 0; i < stackLength; i++)
            {
                sumRecord += scoreRecords.Pop();
            }

            return sumRecord;
        }
    }
}

using System;
namespace LeetCode.Easy
{
	public class NumberStudentsUnableEatLunch
	{
        public int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> studentQueue = new Queue<int>(students);
            Array.Reverse(sandwiches);
            var sandwichStack = new Stack<int>(sandwiches);
            var i = 0;

            while (studentQueue.Count > 0) {
                if (studentQueue.Peek() == sandwichStack.Peek())
                {
                    sandwichStack.Pop();
                    studentQueue.Dequeue();
                    i = 0;
                }
                else {
                    i++;

                    if (i > studentQueue.Count)
                    {
                        break;
                    }

                    studentQueue.Enqueue(studentQueue.Dequeue());
                }
            }

            return studentQueue.Count;
           



        }
    }
}


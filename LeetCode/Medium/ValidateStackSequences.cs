using System;
namespace LeetCode.Medium
{
	public class ValidateStackSequences
	{
		public ValidateStackSequences()
		{
		}

        // Input: pushed = [1,2,3,4,5], popped = [4,5,3,2,1]
        // Output: true
		public bool ValidateStackSequencesSolution(int[] pushed, int[] popped)
		{
			int poppedLength = popped.Length;
			int pushedLength = pushed.Length;

            if (poppedLength != pushedLength) return false;
            if (pushedLength > 1000) return false;

			Stack<int> nums = new Stack<int>();
			int poppedIndex = 0;
			int pushedIndex = 0;

			while(poppedIndex< poppedLength)
			{
				if(nums.Any() && nums.Peek() == popped[poppedIndex])
				{
					nums.Pop();
					poppedIndex++;
					continue;
				}

				if(pushedIndex< pushedLength)
				{
					nums.Push(pushed[pushedIndex++]);
					continue;
				}

				return false;
			}

			return true;
        }
	}
}


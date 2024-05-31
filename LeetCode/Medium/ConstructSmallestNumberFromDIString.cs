using System;
using System.Text;

namespace LeetCode.Medium;

public class ConstructSmallestNumberFromDIString
{
	public ConstructSmallestNumberFromDIString()
	{
	}
	// s ="IIIIDIIDDI"
	// s = 123465798

	public string SmallestNumber(string pattern)
	{
		StringBuilder str = new StringBuilder();
		Stack<int> nums = new Stack<int>();

		for (int i = 1; i <= pattern.Length; i++)
		{
			nums.Push(i);
			if (pattern[i-1] == 'I')
			{
				while (nums.Count>0)
				{
					str.Append(nums.Pop());
				}
			}
		}

		nums.Push(pattern.Length + 1);
		while (nums.Count>0)
		{
			str.Append(nums.Pop());
		}

		return str.ToString();
	}
}

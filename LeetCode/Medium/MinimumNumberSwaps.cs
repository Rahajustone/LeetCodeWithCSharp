using System;
namespace LeetCode.Medium;

public class MinimumNumberSwaps
{
	public MinimumNumberSwaps()
	{
	}

// [[][]]
// ]][[[]
    public int MinSwaps(string s)
    {
	Stack<char> chars = new Stack<char>();
	int countLeft = 0; //]
	foreach (var c in s)
	{
		if (c == '[') chars.Push(c);
		else if (chars.Count > 0) chars.Pop();
		else countLeft++;
	}

	int braces = Math.Max(chars.Count, countLeft);

	return braces%2==0 ? braces / 2 : (braces + 1) / 2; 
    }
}

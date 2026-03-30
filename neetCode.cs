public class Arrays
{

    public int RemoveDuplicates(int[] nums)
    {
    }

    public int RemoveElement(int[] nums, int val)
    {
    }

    public int[] TwoSum(int[] nums, int target)
    {
    }

    public int[] GetConcatenation(int[] nums)
    {
    }

    public int[] RunningSum(int[] nums)
    {
    }

    public int MaximumWealth(int[][] accounts)
    {
    }

    public int[] PlusOne(int[] digits)
    {
    }
}

public class HashingArrays
{

    public bool ContainsDuplicate(int[] nums)
    {
    }

    public bool IsAnagram(string s, string t)
    {
    }
}


public class ArrayTwoPointers
{
    public int[] TwoSum(int[] numbers, int target)
    {
    }
}


public class Stacks
{

    public bool IsValid(string s)
    {
    }

    public int CalPoints(string[] operations)
    {
    }

    public string RemoveDuplicates(string s)
    {
        var stack = new Stack<char>();
        for (var i = 0; i < s.Length; i++)
        {
            if (stack.Count != 0)
            {
                var duplicateFound = s[i] == stack.Peek();
                if (duplicateFound)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }
            else
            {
                stack.Push(s[i]);
            }
        }
        var result = "";
        foreach (var item in stack)
        {
            result = item + result;
        }
        return result;
    }
}











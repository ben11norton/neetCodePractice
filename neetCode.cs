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

    public int PivotIndex(int[] nums)
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

    public int[] Intersection(int[] nums1, int[] nums2)
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
            if (stack.Count == 0)
            {
                stack.Push(s[i]);
            }
            else if (stack.Peek() == s[i])
            {
                stack.Pop();
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











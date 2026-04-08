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

    public bool IsPalindrome(string s)
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
    }

    public bool BackspaceCompare(string s, string t)
    {
        // time complexity
        // O(n + m) where n is length of s and m is length of t
        // we perform O(1) operations on each element of s and t
        // stack1 and stack2 counts are <= n and m so we can ignore these constants 
        var stack1 = new Stack<char>();
        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '#')
            {
                if (stack1.Count != 0)
                {
                    stack1.Pop();
                }
            }
            else
            {
                stack1.Push(s[i]);
            }
        }

        var stack2 = new Stack<char>();
        for (var i = 0; i < t.Length; i++)
        {
            if (t[i] == '#')
            {
                if (stack2.Count != 0)
                {
                    stack2.Pop();
                }
            }
            else
            {
                stack2.Push(t[i]);
            }
        }

        if (stack1.Count != stack2.Count)
        {
            return false;
        }
        else
        {
            foreach (var item in stack1)
            {
                var stack2Item = stack2.Pop();
                if (item != stack2Item)
                {
                    return false;
                }
            }
            return true;
        }
    }
}











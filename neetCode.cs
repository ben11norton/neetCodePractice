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
        // solution is O(n + m)
        // where n is length of s and m is length of formatted string we build
        // time complexity grows linearly based on the length of string s
        // because m will always be <= to n , we can simplify the solution to be O(n)
        var formatted = "";
        for (var i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
            {
                if (char.IsLetter(s[i]))
                {
                    formatted += char.ToLower(s[i]);
                }
                else
                {
                    formatted += s[i];
                }
            }
        }
        int rightPointer = formatted.Length - 1;
        for (var i = 0; i < formatted.Length; i++)
        {
            if (formatted[i] == formatted[rightPointer])
            {
                rightPointer--;
            }
            else
            {
                return false;
            }
        }
        return true;
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
}











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
        // after we switched formatted from a string and concatenation use
        // to using a char array we now have a O(n) solution
        int k = 0;
        var formatted = new char[s.Length];
        for (var i = 0; i < s.Length; i++)
        {
            if (char.IsLetterOrDigit(s[i]))
            {
                if (char.IsLetter(s[i]))
                {
                    formatted[k] = char.ToLower(s[i]);
                    k++;
                }
                else
                {
                    formatted[k] = s[i];
                    k++;
                }
            }
        }
        int rightPointer = k - 1;
        for (var i = 0; i < k; i++)
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











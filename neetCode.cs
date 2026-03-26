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
        var n = numbers.Length;
        var l = 0;
        var r = n - 1;
        for (var i = 0; i < n; i++)
        {
            var sum = numbers[l] + numbers[r];
            if (sum == target)
            {
                return [l + 1, r + 1];
            }
            else if (sum > target)
            {
                r--;
            }
            else if (sum < target)
            {
                l++;
            }
        }
        return new int[0];
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
}











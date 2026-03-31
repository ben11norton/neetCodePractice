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
        for (var pivotIndex = 0; pivotIndex < nums.Length; pivotIndex++)
        {
            var leftSum = 0;
            for (var i = 0; i < pivotIndex; i++)
            {
                leftSum += nums[i];
            }
            var rightSum = 0;
            for (var i = pivotIndex + 1; i < nums.Length; i++)
            {
                rightSum += nums[i];
            }
            if (leftSum == rightSum)
            {
                return pivotIndex;
            }
        }
        return -1;
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
    }
}











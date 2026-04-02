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
        for (var p = 0; p < nums.Length; p++)
        {
            var leftSum = 0;
            for (var i = 0; i < p; i++)
            {
                leftSum += nums[i];
            }

            var rightSum = 0;
            for (var i = p + 1; i < nums.Length; i++)
            {
                rightSum += nums[i];
            }

            if (leftSum == rightSum)
            {
                return p;
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
    }
}











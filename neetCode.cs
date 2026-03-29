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
        var leftPointer = 0;
        var rightPointer = numbers.Length - 1;
        for (var i = 0; i < numbers.Length; i++)
        {
            var sum = numbers[leftPointer] + numbers[rightPointer];
            if (sum == target)
            {
                return [leftPointer + 1, rightPointer + 1];
            }
            else if (sum < target)
            {
                leftPointer++;
            }
            else if (sum > target)
            {
                rightPointer--;
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











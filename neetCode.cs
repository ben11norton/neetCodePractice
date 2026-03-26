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
        // need to redo this one
        // we got the correct answer but still is O(n sqaured in worst case)
        // as basically doing a nested loop here
        var k = 0;
        for (var i = 1; i < numbers.Length; i++)
        {
            if (numbers[k] == target - numbers[i])
            {
                return [k + 1, i + 1];
            }
            else
            {
                if (i == numbers.Length - 1 && k != numbers.Length - 2)
                {
                    k++;
                    i = k;
                }
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











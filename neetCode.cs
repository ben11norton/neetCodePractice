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
        if (s.Length != t.Length)
        {
            return false;
        }
        else
        {
            var map = new Dictionary<char, int>();
            for (var i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map[s[i]] = 1;
                }
                else
                {
                    map[s[i]]++;
                }
            }
            for (var i = 0; i < t.Length; i++)
            {
                if (map.ContainsKey(t[i]))
                {
                    if (map[t[i]] != 0)
                    {
                        map[t[i]]--;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
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
}











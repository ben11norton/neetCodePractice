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
        // time complexity is O(n)
        // where n is the length of s and t
        // we are iterating over each element of s and performing O(1) operations to build our map
        // we then loop through each element of t and perform O(1) look up operations
        // so total time becomes O(2n) which becomes O(n) as we are not concerned about constants
        // total time is linear to the length of the strings
        if (s.Length != t.Length)
        {
            return false;
        }

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
                if (map[t[i]] > 0)
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


public class ArrayTwoPointers
{
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











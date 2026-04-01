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
        // time complexity :
        // we iterate over each element in nums1 so O(n) where n is length of nums1
        // each element we perform a O(1) constant operation to build our map
        // we then iterate over each elemnt in nums2 once, so O(m) where m is length of nums2
        // peform O(1) look ups and constant operations inside second loop
        // we then iterate over each element in our result Array so O(k) where k is resultCount
        // so overall we have O(n + m + k) but because k <=n, it can be absorbed into n
        // so time complexity become O(n + m), space complexity is O(n) as we store n elements in our dictionary
        var map = new Dictionary<int, bool>();
        for (var i = 0; i < nums1.Length; i++)
        {
            if (!map.ContainsKey(nums1[i]))
            {
                map[nums1[i]] = false;
            }
        }
        int resultCount = 0;
        for (var i = 0; i < nums2.Length; i++)
        {
            if (map.ContainsKey(nums2[i]))
            {
                if (!map[nums2[i]])
                {
                    map[nums2[i]] = true;
                    resultCount++;
                }
            }
        }
        var resultArray = new int[resultCount];
        var resultArrayIndex = 0;
        foreach (var item in map)
        {
            if (item.Value)
            {
                resultArray[resultArrayIndex] = item.Key;
                resultArrayIndex++;
            }
        }
        return resultArray;
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











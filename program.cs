public class Program
{
    public int FindLHS(int[] nums)
    {
        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (!map.ContainsKey(nums[i]))
            {
                map[nums[i]] = 1;
            }
            else
            {
                map[nums[i]]++;
            }
        }
        int largestCount = 0;
        foreach (var (key, value) in map)
        {
            if (map.ContainsKey(key + 1))
            {
                var successorCount = map[key + 1];
                var totalCount = map[key] + successorCount;
                if (totalCount > largestCount)
                {
                    largestCount = totalCount;
                }
            }
        }
        return largestCount;
    }
}






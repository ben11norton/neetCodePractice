public class Program
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        var map = new Dictionary<int, bool>();
        for (int i = 0; i <= n; i++)
        {
            map[i] = false;
        }
        for (int i = 0; i < n; i++)
        {
            if (map.ContainsKey(nums[i]))
            {
                map[nums[i]] = true;
            }
        }
        int missingNumber = 0;
        foreach (var (key, value) in map)
        {
            if (value == false)
            {
                missingNumber = key;
            }
        }
        return missingNumber;
    }
}






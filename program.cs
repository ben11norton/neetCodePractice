public class Program
{
    public int MajorityElement(int[] nums)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
            }
            else
            {
                map[nums[i]] = 1;
            }
        }
        int maxCount = 0;
        int majorityElement = 0;
        foreach (var (key, value) in map)
        {
            if (value > maxCount)
            {
                maxCount = value;
                majorityElement = key;
            }
        }
        return majorityElement;
    }
}






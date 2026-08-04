public class Program
{
    public int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var sNum = target - nums[i];
            if (map.ContainsKey(sNum))
            {
                var sNumIndex = map[sNum];
                return [sNumIndex, i];
            }
            else
            {
                map[nums[i]] = i;
            }
        }
        return new int[0];
    }
}






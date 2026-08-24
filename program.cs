public class Program
{
    public bool ContainsDuplicate(int[] nums)
    {
        var map = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!map.Contains(nums[i]))
            {
                map.Add(nums[i]);
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}






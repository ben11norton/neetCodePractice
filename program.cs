public class Program
{
    public int MajorityElement(int[] nums)
    {
        // boyer moore algorithm
        int candidate = 0;
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (count == 0)
            {
                candidate = nums[i];
            }
            if (candidate == nums[i])
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        return candidate;
    }
}






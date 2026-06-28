public class Program
{
    public int RemoveDuplicates(int[] nums)
    {
        int k = 2;
        if (nums.Length <= 2)
        {
            return nums.Length;
        }
        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] != nums[k - 2])
            {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}






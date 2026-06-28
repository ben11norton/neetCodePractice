public class Program
{
    public int MajorityElement(int[] nums)
    {
        int number = nums[0];
        int half = nums.Length / 2;
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (count == 0)
            {
                number = nums[i];
            }
            if (number == nums[i])
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        return number;
    }
}






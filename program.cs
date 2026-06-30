public class Program
{
    public int FindNumbers(int[] nums)
    {
        int evenCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i].ToString().Length % 2 == 0)
            {
                evenCount++;
            }
        }
        return evenCount;
    }
}






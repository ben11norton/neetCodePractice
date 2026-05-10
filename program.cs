public class Program
{
    public int MaxSubArray(int[] nums)
    {
        int sum = nums[0];
        int bestSum = sum;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i] + sum)
            {
                sum = nums[i];
            }
            else
            {
                sum += nums[i];
            }
            if (sum > bestSum)
            {
                bestSum = sum;
            }
        }
        return bestSum;
    }
}






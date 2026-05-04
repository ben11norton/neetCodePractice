public class Program
{
    public int MaxSubArray(int[] nums)
    {
        var sum = nums[0];
        var bestSum = sum;
        for (var i = 1; i < nums.Length; i++)
        {
            var newSum = sum + nums[i];
            if (nums[i] > newSum)
            {
                sum = nums[i];
            }
            else
            {
                sum = newSum;
            }
            if (sum > bestSum)
            {
                bestSum = sum;
            }
        }
        return bestSum;
    }
}






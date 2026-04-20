public class Program
{
    public double FindMaxAverage(int[] nums, int k)
    {
        double windowSum = 0;
        for (var i = 0; i < k; i++)
        {
            windowSum += nums[i];
        }
        double maxAvg = windowSum / k;
        for (var i = k; i < nums.Length; i++)
        {
            windowSum += nums[i];
            windowSum -= nums[i - k];
            var windowAvg = windowSum / k;
            if (windowAvg > maxAvg)
            {
                maxAvg = windowAvg;
            }
        }
        return maxAvg;
    }
}






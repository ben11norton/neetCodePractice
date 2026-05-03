public class Program
{
    public int NumOfSubarrays(int[] arr, int k, int threshold)
    {
        double windowSum = 0;
        var windowCount = 0;
        double windowAvg = 0;
        for (var i = 0; i < k; i++)
        {
            windowSum += arr[i];
            windowAvg = (double)windowSum / k;
        }
        if (windowAvg >= threshold)
        {
            windowCount++;
        }
        for (var i = k; i < arr.Length; i++)
        {
            windowSum += arr[i];
            windowSum -= arr[i - k];
            var newWindowAvg = (double)windowSum / k;
            if (newWindowAvg >= threshold)
            {
                windowCount++;
            }
        }
        return windowCount;
    }
}






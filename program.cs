public class Program
{
    public int NumOfSubarrays(int[] arr, int k, int threshold)
    {
        double windowSum = 0;
        int successfullWindowCount = 0;
        for (var i = 0; i < k; i++)
        {
            windowSum += arr[i];
        }
        var windowAvg = windowSum / k;
        if (windowAvg >= threshold)
        {
            successfullWindowCount++;
        }
        for (var i = k; i < arr.Length; i++)
        {
            windowSum += arr[i];
            windowSum -= arr[i - k];
            var newAvg = windowSum / k;
            if (newAvg >= threshold)
            {
                successfullWindowCount++;
            }
        }
        return successfullWindowCount;
    }
}






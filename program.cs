public class Program
{
    public int MaxSubArray(int[] nums)
    {
        var largestSum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            largestSum += nums[i];
        }
        for (var i = 0; i < nums.Length; i++)
        {
            var sum = nums[i];
            if (sum > largestSum)
            {
                largestSum = sum;
            }
            for (var j = i + 1; j < nums.Length; j++)
            {
                sum += nums[j];
                if (sum > largestSum)
                {
                    largestSum = sum;
                }
            }
        }
        return largestSum;
    }
}






public class Program
{
    public double FindMaxAverage(int[] nums, int k) {
        var windowSum = 0;
        double maxAvg = 0;
        for(var i = 0; i < k; i++){
            windowSum += nums[i];
        }
        maxAvg = (double)windowSum / k;
        for(var i = k; i < nums.Length; i++){
            windowSum -= nums[i - k];
            windowSum += nums[i]; 
            var newAvg = (double)windowSum / k;
            if(newAvg > maxAvg){
                maxAvg = newAvg;
            }
        }
        return maxAvg;
    }
}






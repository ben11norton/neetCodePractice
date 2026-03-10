public class Program{

    public int[] RunningSum(int[] nums) {
        // solution has a time complexity of O(n)
        // where n is the length of the input array nums
        // because we are iterating over each element in the array once
        // and perform constant time operations each iteration
        
        // we are also creating a new array with size of n 
        // so our space complexity is also O(n)
        int sum = 0;
        var runningSum = new int[nums.Length];
        for(var i = 0; i < nums.Length; i++){
            sum += nums[i];
            runningSum[i] = sum;
        }
        return runningSum;
    }

}

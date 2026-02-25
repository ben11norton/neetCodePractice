public class Solution {
    // Input: nums = [1,1,2,3,4]
    // Output: [1,2,3,4]
    // Explanation: You should return k = 4 as we have four unique elements. 

    // The first k elements of nums must contain the unique values.
    // what does the above actually mean
    // 
    public int RemoveDuplicates(int[] nums) {
        // loop through nums
        // have 2 pointers
        // our right pointer is going traverse every num in array this can be i
        // our left pointer is going to keep the index of our last unique number
        // this can be k

        // we know that our first num is unique so lets start at 1
        int k = 1;

        for(var i = 1; i < nums.Length; i++){
            // so we need to compare our current number
            var currentNum = nums[i];
            // to our previous num
            var previousNum = nums[i - 1];

            // if our previousNum is the same as our current number
            // then we don't increment k and keep looping to the next number

            // if our previousNum is different than our current number
            if(currentNum != previousNum){
                // then we are going to place our current number with our right pointer
                // [1,1,2,3,4]
                //  k ^
                nums[k] = currentNum;
                k++;
                // at the position our left pointer is at
                // and then we are going to increment left pointer by one
                // then keep traversing the array with both pointers
            }
        }

        return k;
    }



    // from now on we are going to use white board to think first
    // then we can code the solution starting from this method below:
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int k = n;
        var ans = new int[n*2];

        for(var i = 0; i < n; i++){
            var number = nums[i];
            ans[i] = number;
            ans[k] = number;
            k++;
        }

        return ans;
    }
}

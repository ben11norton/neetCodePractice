public class Solution {
    // Min Stack
    // work through the solutions below with white board and check off on notion
    // then create a new class called min stack and solve the above
 
    // Valid Parenthesis:
    public bool IsValid(string s) {
    }


    public int RemoveDuplicates(int[] nums) {
    }


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

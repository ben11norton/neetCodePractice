public class Arrays {

    // Time Complexity: O(n) — single linear pass.
    // Space Complexity: O(1) — in-place modification with constant extra memory.

    public int RemoveDuplicates(int[] nums) {
        int k = 1; // our uniqueElementIndexPointer

        for(var i = 1; i < nums.Length; i++){
            var currentNumber = nums[i];
            var previousNumber = nums[i - 1];

            var isUniqueNumber = currentNumber != previousNumber;

            if(isUniqueNumber){
                var uniqueNumberIndex = k;
                nums[uniqueNumberIndex] = currentNumber;
                k++;
            }
        }

        return k;
    }

    public int[] TwoSum(int[] nums, int target) {
    }

    public int[] GetConcatenation(int[] nums) {
    }
}

public class HashingArrays {
}


public class ArrayTwoPointers {
}


public class Stacks {
}

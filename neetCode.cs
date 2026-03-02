public class Arrays {

    public int[] GetConcatenation(int[] nums) {
        var n = nums.Length;
        var ansLength = n * 2;
        var ans = new int[ansLength];

        for(int i = 0; i < nums.Length; i++){
            var currentNumber = nums[i];
            ans[i] = currentNumber;
            ans[i + n] = currentNumber;
        }

        return ans;
    }
}

public class HashingArrays {
}


public class ArrayTwoPointers {
}


public class Stacks {
}

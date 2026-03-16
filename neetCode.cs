public class Arrays {

    public int RemoveDuplicates(int[] nums) {
    }

    public int RemoveElement(int[] nums, int val) {
        var k = 0;
        for(var i = 0; i < nums.Length; i++){
            if(nums[i] != val){
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }

    public int[] TwoSum(int[] nums, int target) {
    }

    public int[] GetConcatenation(int[] nums) {
    }

    public int[] RunningSum(int[] nums) {
    }
}

public class HashingArrays {

    public bool ContainsDuplicate(int[] nums) {
    }
}


public class ArrayTwoPointers {
}


public class Stacks {


    public bool IsValid(string s) {
    }

}











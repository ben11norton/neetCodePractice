public class Arrays {

    public int[] TwoSum(int[] nums, int target) {
        // hasMap to store our current number as the key
        // and the index as the value (because we are interested in the indeces as the return values)
        var hashMap = new Dictionary<int, int>();

        for(var i = 0; i < nums.Length; i++){
            var currentIndex = i;
            var currentNum = nums[currentIndex];

            var difference = target - currentNum;
            // check if our hashMap has the difference (the number that sums up to target with our current number)
            var containsMissingNumber = hashMap.ContainsKey(difference);
            if(containsMissingNumber){
                return [currentIndex, hashMap[difference]];

            } else{
                hashMap[currentNum] = currentIndex;
            }
        }

        return []; // returning and empty array incase it doesn't find a match
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

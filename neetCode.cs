public class Arrays {

    public int RemoveDuplicates(int[] nums) {
    }

    public int[] TwoSum(int[] nums, int target) {
    }

    public int[] GetConcatenation(int[] nums) {
    }
}

public class HashingArrays {

    public bool ContainsDuplicate(int[] nums) {
        var map = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; i++){
            if(!map.ContainsKey(nums[i])){
                map[nums[i]] = i;
            } else{
                return true;
            }
        }
        return false;
    }
}


public class ArrayTwoPointers {
}


public class Stacks {


    public bool IsValid(string s) {
        var stack = new Stack<char>();

        var matchingMap = new Dictionary<char, char>{
            {'(', ')'},
            {'[', ']'},
            {'{', '}'}
        };

        for(var i = 0; i < s.Length; i++){
            var currentBracket = s[i];

            if(matchingMap.ContainsKey(currentBracket)){
                stack.Push(currentBracket);

            } else{

                if(stack.Count == 0){
                    return false;

                } else{
                    var lastAddedOpeningBracket = stack.Pop();
                    var matchingBracket = matchingMap[lastAddedOpeningBracket] == currentBracket;
                    if(!matchingBracket){
                        return false;
                    }
                }
            }
        }

        var stackIsEmpty = stack.Count == 0;
        return stackIsEmpty;
        // this solution is O(n)
        // we loop through each character in the string only once so grows linarly with length of string
        // using .Pop or .Push operations are O(1) operations
        // use of dictionary is also O(1) look up
        // so our time complexity is O(n)
        // so n * O(1) = O(n)
    }

}

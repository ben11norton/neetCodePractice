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
    }
}


public class ArrayTwoPointers {
}


public class Stacks {


    public bool IsValid(string s) {
        var stack = new Stack<char>();
        var map = new Dictionary<char, char>(){
            {'(', ')'},
            {'[', ']'},
            {'{', '}'}
        };
        for(var i = 0; i < s.Length; i++){
            var currentBracket = s[i];
            if(map.ContainsKey(currentBracket)){
                stack.Push(currentBracket);
            } else{
                if(stack.Count == 0){
                    return false;
                }
                var lastAddedOpeningBracket = stack.Pop();
                var closingBracketToMatch = map[lastAddedOpeningBracket];
                if(currentBracket != closingBracketToMatch){
                    return false;
                }
            }
        }
        var stackIsEmpty = stack.Count == 0;
        return stackIsEmpty;
    }

}











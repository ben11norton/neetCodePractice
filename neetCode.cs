public class Arrays {

    public int RemoveDuplicates(int[] nums) {
    }

    public int RemoveElement(int[] nums, int val) {
    }

    public int[] TwoSum(int[] nums, int target) {
    }

    public int[] GetConcatenation(int[] nums) {
    }

    public int[] RunningSum(int[] nums) {
    }

    public int MaximumWealth(int[][] accounts) {
        var maxWealth = 0;
        for(var i = 0; i < accounts.Length; i++){
            var account = accounts[i];
            var accountSum = 0;
            for(var j = 0; j < account.Length; j++){
                accountSum += account[j];
                if(accountSum > maxWealth){
                    maxWealth = accountSum;
                }
            }
        }
        return maxWealth;
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

    public int CalPoints(string[] operations) {
        var stack = new Stack<int>();
        for(var i = 0; i < operations.Length; i++){
            if(int.TryParse(operations[i], out int num)){
                stack.Push(num);
            } else if(operations[i] == "C"){
                stack.Pop();
            } else if(operations[i] == "D"){
                var prevScore = stack.Peek();
                var doubleScore  = 2 * prevScore;
                stack.Push(doubleScore);
            } else if(operations[i] == "+"){
                var top = stack.Pop();
                var secondTop = stack.Peek();
                var sumOfTop2 = top + secondTop;
                stack.Push(top);
                stack.Push(sumOfTop2);
            }
        }
        var sum = 0;
        if(stack.Count == 0){
            return sum;
        } else{
            foreach(var num in stack){
                sum += num;
            }
            return sum;
        }
    }

}











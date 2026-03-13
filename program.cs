public class Program{

    public int[] TopKFrequent(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; i++){
            if(!map.ContainsKey(nums[i]){
                map[nums[i]] = 1;
            } else{
                map[nums[i]]++;
            }
        }

        var topKNums = new int[k];
        var topKValues = new int[k];
        foreach(var (key, value) in map){
            var currentKey = key;
            var currentValue = value;
            for(var i = 0; i < topKNums.Length; i++){
                if(currentValue > topKValues[i]){
                    var tempValue = topKValues[i];
                    topKValues[i] = currentValue;
                    currentValue = tempValue;
                    var tempKey = topKNums[i];
                    topKNums[i] = currentKey;
                    currentKey = tempKey;
                }
            }
        }
        return topKNums;
    }
}

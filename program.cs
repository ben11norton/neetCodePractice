public class Program
{
    public int ClimbStairs(int n)
    {
        var waysMap = new Dictionary<int, int>(){
            {1, 1},
            {2, 2}
        };
        for (int i = 3; i < n + 1; i++)
        {
            var ways = waysMap[i - 1] + waysMap[i - 2];
            waysMap[i] = ways;
        }
        var waysN = waysMap[n];
        return waysN;
    }
}






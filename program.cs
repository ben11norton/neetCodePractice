public class Program
{
    public int MaxProfit(int[] prices)
    {
        var maxProfit = 0;
        var lowestNum = prices[0];
        for (var i = 1; i < prices.Length; i++)
        {
            if (lowestNum > prices[i - 1])
            {
                lowestNum = prices[i - 1];
            }
            var profit = prices[i] - lowestNum;
            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
        }
        return maxProfit;
    }
}

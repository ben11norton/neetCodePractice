public class Program
{
    public int MaxProfit(int[] prices)
    {
        var maxProfit = 0;
        var buyPrice = prices[0];
        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i - 1] < buyPrice)
            {
                buyPrice = prices[i - 1];
            }
            var profit = prices[i] - buyPrice;
            if (profit > maxProfit)
            {
                maxProfit = profit;
            }
        }
        return maxProfit;
    }
}

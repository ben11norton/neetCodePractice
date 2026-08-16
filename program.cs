public class Program
{
    public int MaxProfit(int[] prices)
    {
        int bestBuy = 0;
        bool bestBuyAssigned = false;
        int maxProfit = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i - 1] < prices[i])
            {
                int potentialBuy = prices[i - 1];
                if (potentialBuy < bestBuy || !bestBuyAssigned)
                {
                    bestBuy = potentialBuy;
                    bestBuyAssigned = true;
                }
                int potentialSell = prices[i];
                int potentialProfit = potentialSell - bestBuy;
                if (potentialProfit > maxProfit)
                {
                    maxProfit = potentialProfit;
                }
            }
        }
        return maxProfit;
    }
}






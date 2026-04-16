public class Program
{
    public int[] FinalPrices(int[] prices)
    {
        var stack = new Stack<int>();
        for (var i = 0; i < prices.Length; i++)
        {
            while (stack.Count > 0 && prices[stack.Peek()] >= prices[i])
            {
                var index = stack.Pop();
                prices[index] -= prices[i];
            }
            stack.Push(i);
        }
        return prices;
    }
}

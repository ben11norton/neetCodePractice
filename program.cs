public class Program
{
    public int[] CountBits(int n)
    {
        var ans = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            int number1Count = 0;
            int number = i;
            while (number != 0)
            {
                number = number & number - 1;
                number1Count++;
            }
            ans[i] = number1Count;
        }
        return ans;
    }
}






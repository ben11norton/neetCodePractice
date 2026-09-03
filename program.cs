public class Program
{
    public int[] CountBits(int n)
    {
        var binaryNArray = new string[n + 1];
        for (int i = 0; i <= n; i++)
        {
            string binaryN = Convert.ToString(i, 2);
            binaryNArray[i] = binaryN;
        }
        var ans = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            int number1Count = 0;
            foreach (var binaryRep in binaryNArray[i])
            {
                if (binaryRep == '1')
                {
                    number1Count++;
                }
            }
            ans[i] = number1Count;
        }
        return ans;
    }
}






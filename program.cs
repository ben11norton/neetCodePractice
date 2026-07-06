public class Program
{
    public int FindContentChildren(int[] g, int[] s)
    {
        g = checkAscOrder(g);
        s = checkAscOrder(s);
        int j = 0;
        int count = 0;
        for (int i = 0; i < g.Length; i++)
        {
            if (j <= s.Length - 1)
            {
                if (s[j] >= g[i])
                {
                    count++;
                    j++;
                }
                else
                {
                    while (j < s.Length - 1 && s[j] <= g[i])
                    {
                        j++;
                    }
                    if (s[j] >= g[i])
                    {
                        count++;
                    }
                }
            }
        }
        return count;
    }

    private int[] checkAscOrder(int[] inputArray)
    {
        if (inputArray.Length > 1)
        {
            if (inputArray[0] > inputArray[1])
            {
                var sorted = new int[inputArray.Length];
                int j = 0;
                for (int i = inputArray.Length - 1; i >= 0; i--)
                {
                    sorted[j] = inputArray[i];
                    j++;
                }
                return sorted;
            }
        }
        return inputArray;
    }
}






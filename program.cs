public class Program
{
    public int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        int i = 0;
        int j = 0;
        int count = 0;
        while (i < g.Length && j < s.Length)
        {
            if (s[j] >= g[i])
            {
                i++;
                j++;
                count++;
            }
            else if (s[j] < g[i])
            {
                j++;
            }
        }
        return count;
    }
}






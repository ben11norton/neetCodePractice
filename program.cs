public class Program
{
    public bool IsHappy(int n)
    {
        n = GetNewN(n);
        int map = new HashSet<int>();
        while (n != 1)
        {
            n = GetNewN(n);
            if (map.Contains(n))
            {
                return false;
            }
            else
            {
                map.Add(n);
            }
        }
        return true;
    }

    private int GetNewN(int n)
    {
        string sN = n.ToString();
        int newN = 0;
        for (var i = 0; i < sN.Length; i++)
        {
            int x = int.Parse(sN[i].ToString());
            int square = x * x;
            newN += square;
        }
        return newN;
    }
}






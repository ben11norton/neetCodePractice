public class Program
{
    public int HammingWeight(int n)
    {
        // 1. brute force conerting n to binary string
        // and counting 1's
        string binaryN = Convert.ToString(n, 2);
        int setBits = 0;
        for (int i = 0; i < binaryN.Length; i++)
        {
            if (binaryN[i] == '1')
            {
                setBits++;
            }
        }
        return setBits;
    }
}






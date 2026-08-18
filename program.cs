public class Program
{
    public int ReverseBits(int n)
    {
        string binaryString = Convert.ToString(n, 2).PadLeft(32, '0');
        var binaryStringArray = binaryString.ToCharArray();
        int l = 0;
        int r = binaryStringArray.Length - 1;
        while (l < r)
        {
            var swap = binaryStringArray[l];
            binaryStringArray[l] = binaryStringArray[r];
            binaryStringArray[r] = swap;
            l++;
            r--;
        }
        binaryString = new string(binaryStringArray);
        int reverseBits = Convert.ToInt32(binaryString, 2);
        return reverseBits;
    }
}






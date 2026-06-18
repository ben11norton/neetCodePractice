public class Program
{
    public int LengthOfLongestSubstring(string s)
    {
        var map = new HashSet<char>();
        int count = 0;
        int maxLength = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (map.Contains(s[i]))
            {
                count = 1;
            }
            else
            {
                map.Add(s[i]);
                count++;
                if (count > maxLength)
                {
                    maxLength = count;
                }
            }
        }
        return maxLength;
    }
}






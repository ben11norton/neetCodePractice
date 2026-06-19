public class Program
{
    public int LengthOfLongestSubstring(string s)
    {
        int maxLength = 0;
        int k = 0; // leftPointer
        var window = new HashSet<char>();
        for (int i = 0; i < s.Length; i++)
        {
            // 1. build window
            if (!window.Contains(s[i]))
            {
                window.Add(s[i]);
                if (window.Count > maxLength)
                {
                    maxLength = window.Count;
                }
            }
            else
            {
                // 2. slide window
                while (window.Contains(s[i]))
                {
                    window.Remove(s[k]);
                    k++;
                }
                window.Add(s[i]);
            }
        }
        return maxLength;
    }
}






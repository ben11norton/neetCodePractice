public class Program
{
    public int FirstUniqChar(string s)
    {
        var map = new Dictionary<char, int>();
        for (var i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
                map[s[i]]++;
            }
            else
            {
                map[s[i]] = 1;
            }
        }
        for (var i = 0; i < s.Length; i++)
        {
            if (map[s[i]] == 1)
            {
                return i;
            }
        }
        return -1;
    }
}






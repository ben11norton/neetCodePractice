public class Program
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        var mapS = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (mapS.ContainsKey(s[i]))
            {
                mapS[s[i]]++;
            }
            else
            {
                mapS[s[i]] = 1;
            }
        }
        for (int i = 0; i < t.Length; i++)
        {
            var tlower = char.ToLower(t[i]);
            if (mapS.ContainsKey(tlower))
            {
                if (mapS[tlower] > 0)
                {
                    mapS[tlower]--;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}






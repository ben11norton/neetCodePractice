public class Program
{
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length == t.Length)
        {
            var mapS = new Dictionary<char, char>();
            for (var i = 0; i < s.Length; i++)
            {
                if (!mapS.ContainsKey(s[i]))
                {
                    mapS[s[i]] = t[i];
                }
                else if (mapS[s[i]] != t[i])
                {
                    return false;
                }
            }
            var mapT = new Dictionary<char, char>();
            for (var i = 0; i < t.Length; i++)
            {
                if (!mapT.ContainsKey(t[i]))
                {
                    mapT[t[i]] = s[i];
                }
                else if (mapT[t[i]] != s[i])
                {
                    return false;
                }
            }
            return true;
        }
        else
        {
            return false;
        }
    }
}






public class Program
{
    public bool WordPattern(string pattern, string s)
    {
        var sMap = new Dictionary<string, char>();
        var pMap = new Dictionary<char, string>();
        var sArray = s.Split(' ');
        if (pattern.Length != sArray.Length)
        {
            return false;
        }
        for (int i = 0; i < pattern.Length; i++)
        {
            if (!pMap.ContainsKey(pattern[i]))
            {
                pMap[pattern[i]] = sArray[i];
            }
            else
            {
                if (pMap[pattern[i]] != sArray[i])
                {
                    return false;
                }
            }
            if (!sMap.ContainsKey(sArray[i]))
            {
                sMap[sArray[i]] = pattern[i];
            }
            else
            {
                if (sMap[sArray[i]] != pattern[i])
                {
                    return false;
                }
            }
        }
        return true;
    }
}






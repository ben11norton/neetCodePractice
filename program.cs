public class Program
{
    public bool WordPattern(string pattern, string s)
    {
        var patternMap = new Dictionary<char, string>();
        var wordMap = new Dictionary<string, char>();
        var sArray = s.Split(' ');
        if (pattern.Length != sArray.Length)
        {
            return false;
        }
        for (var i = 0; i < pattern.Length; i++)
        {
            if (!patternMap.ContainsKey(pattern[i]))
            {
                patternMap[pattern[i]] = sArray[i];
            }
            else
            {
                if (sArray[i] != patternMap[pattern[i]])
                {
                    return false;
                }
            }
            if (!wordMap.ContainsKey(sArray[i]))
            {
                wordMap[sArray[i]] = pattern[i];
            }
            else
            {
                if (pattern[i] != wordMap[sArray[i]])
                {
                    return false;
                }
            }
        }
        return true;
    }
}






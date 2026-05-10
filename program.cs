public class Program
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var map = new Dictionary<char, int>();
        for (var i = 0; i < magazine.Length; i++)
        {
            if (map.ContainsKey(magazine[i]))
            {
                map[magazine[i]]++;
            }
            else
            {
                map[magazine[i]] = 1;
            }
        }
        for (var i = 0; i < ransomNote.Length; i++)
        {
            if (map.ContainsKey(ransomNote[i]))
            {
                if (map[ransomNote[i]] > 0)
                {
                    map[ransomNote[i]]--;
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






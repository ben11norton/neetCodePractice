public class Program
{
    public string ReverseVowels(string s)
    {
        var vowels = new HashSet<char>(){
            'a', 'e', 'i', 'o', 'u'
        };
        int i = 0;
        int j = s.Length - 1;
        var sCharArray = s.ToCharArray();
        while (i < j)
        {
            if (vowels.Contains(char.ToLower(s[i])) && vowels.Contains(char.ToLower(s[j])))
            {
                var temp = s[i];
                sCharArray[i] = sCharArray[j];
                sCharArray[j] = temp;
                i++;
                j--;
            }
            else if (!vowels.Contains(char.ToLower(s[i])) && !vowels.Contains(char.ToLower(s[j])))
            {
                i++;
                j--;
            }
            else if (!vowels.Contains(char.ToLower(s[i])))
            {
                i++;
            }
            else if (!vowels.Contains(char.ToLower(s[j])))
            {
                j--;
            }
        }
        return new String(sCharArray);
    }
}






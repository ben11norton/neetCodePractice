public class Program
{
    public bool IsPalindrome(string s)
    {
        var charArray = new char[s.Length];
        var charArrayIndex = 0;
        for (var i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]))
            {
                charArray[charArrayIndex] = char.ToLower(s[i]);
                charArrayIndex++;
            }
            else if (char.IsDigit(s[i]))
            {
                charArray[charArrayIndex] = s[i];
                charArrayIndex++;
            }
        }
        var r = charArrayIndex - 1;
        for (var i = 0; i < charArrayIndex; i++)
        {
            if (charArray[i] == charArray[r])
            {
                r--;
            }
            else
            {
                return false;
            }
        }
        return true;
    }
}

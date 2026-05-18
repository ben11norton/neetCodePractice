public class Program
{
    public bool BackspaceCompare(string s, string t)
    {
        string newS = BackspaceString(s);
        string newT = BackspaceString(t);
        return newS == newT;
    }

    private string BackspaceString(string s)
    {
        int backspaceCount = 0;
        string newS = "";
        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == '#')
            {
                backspaceCount++;
            }
            else if (backspaceCount > 0)
            {
                backspaceCount--;
            }
            else
            {
                newS = s[i] + newS;
            }
        }
        return newS;
    }
}






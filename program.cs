public class Program
{
    public void ReverseString(char[] s)
    {
        var R = s.Length - 1;
        for (var i = 0; i < s.Length / 2; i++)
        {
            var temp = s[i];
            s[i] = s[R];
            s[R] = temp;
            R--;
        }
    }
}






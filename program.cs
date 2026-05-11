public class Program
{
    public string MakeGood(string s)
    {
        var stack = new Stack<char>();
        stack.Push(s[0]);
        for (var i = 1; i < s.Length; i++)
        {
            if (stack.Count > 0)
            {
                var previous = stack.Peek();
                if (char.ToLower(previous) == char.ToLower(s[i]) && previous != s[i])
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);
                }
            }
            else
            {
                stack.Push(s[i]);
            }
        }
        string cleanString = "";
        int newSLength = stack.Count;
        for (var i = 0; i < newSLength; i++)
        {
            cleanString = stack.Pop() + cleanString;
        }
        return cleanString;
    }
}






public class Program
{
    public string MakeGood(string s)
    {
        var stack = new Stack<char>();
        stack.Push(s[0]);
        for (var i = 1; i < s.Length; i++)
        {
            if (stack.Count > 0 && char.ToLower(s[i]) == char.ToLower(stack.Peek()) && s[i] != stack.Peek())
            {
                stack.Pop();
            }
            else
            {
                stack.Push(s[i]);
            }
        }
        int stackCount = stack.Count();
        var charArray = new char[stackCount];
        for (var i = stackCount - 1; i >= 0; i--)
        {
            charArray[i] = stack.Pop();
        }
        return new string(charArray);
    }
}






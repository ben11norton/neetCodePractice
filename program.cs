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
        string newString = "";
        for (var i = 0; i < stackCount; i++)
        {
            newString = stack.Pop() + newString;
        }
        return newString;
    }
}






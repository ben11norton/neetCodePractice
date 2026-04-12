public class Program
{
    public bool BackspaceCompare(string s, string t)
    {
        var stackS = BuildStack(s);
        var stackT = BuildStack(t);

        if (stackS.Count != stackT.Count)
        {
            return false;
        }
        else
        {
            foreach (var item in stackS)
            {
                var stackTItem = stackT.Pop();
                if (item != stackTItem)
                {
                    return false;
                }
            }
            return true;
        }
    }

    private Stack<char> BuildStack(string input)
    {
        var stack = new Stack<char>();
        for (var i = 0; i < input.Length; i++)
        {
            if (input[i] == '#')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(input[i]);
            }
        }
        return stack;
    }
}

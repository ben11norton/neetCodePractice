public class Program
{
    public int MinOperations(string[] logs)
    {
        var stack = new Stack<string>();
        for (var i = 0; i < logs.Length; i++)
        {
            if (logs[i] == "../" && stack.Count > 0)
            {
                stack.Pop();
            }
            else if (logs[i] != "./" && logs[i] != "../")
            {
                stack.Push(logs[i]);
            }
        }
        return stack.Count;
    }
}






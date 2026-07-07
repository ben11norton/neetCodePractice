public class Program
{
    public string RemoveStars(string s)
    {
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '*')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(s[i]);
            }
        }
        if (stack.Count > 0)
        {
            var sArray = new char[stack.Count];
            int index = stack.Count - 1;
            foreach (var item in stack)
            {
                sArray[index] = item;
                index--;
            }
            return new String(sArray);
        }
        else
        {
            return "";
        }
    }
}






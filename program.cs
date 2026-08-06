public class Program
{
    public bool IsValid(string s)
    {
        var openingMap = new Dictionary<char, char>(){
            {'(', ')'},
            {'[', ']'},
            {'{', '}'},
        };
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (openingMap.ContainsKey(s[i]))
            {
                stack.Push(s[i]);
            }
            else if (stack.Count == 0)
            {
                return false;
            }
            else
            {
                var lastOpening = stack.Pop();
                var bracketToMatch = openingMap[lastOpening];
                if (s[i] != bracketToMatch)
                {
                    return false;
                }
            }
        }
        if (stack.Count > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}






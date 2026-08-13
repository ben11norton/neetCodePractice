public class Program
{
    public bool IsPalindrome(string s)
    {
        int leftPointer = 0;
        int rightPointer = s.Length - 1;
        while (leftPointer != rightPointer && leftPointer < s.Length)
        {
            if (char.IsLetterOrDigit(s[leftPointer]) && char.IsLetterOrDigit(s[rightPointer]))
            {
                if (char.ToLower(s[leftPointer]) == char.ToLower(s[rightPointer]))
                {
                    leftPointer++;
                    rightPointer--;
                }
                else
                {
                    return false;
                }
            }
            else if (!char.IsLetterOrDigit(s[leftPointer]))
            {
                leftPointer++;
            }
            else if (!char.IsLetterOrDigit(s[rightPointer]))
            {
                rightPointer--;
            }
        }
        return true;
    }
}






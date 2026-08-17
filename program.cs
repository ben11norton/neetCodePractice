public class Program
{
    public bool HasCycle(ListNode head)
    {
        var hashSet = new HashSet<ListNode>();
        var current = head;
        while (current != null)
        {
            if (!hashSet.Contains(current))
            {
                hashSet.Add(current);
            }
            else
            {
                return true;
            }
            current = current.next;
        }
        return false;
    }
}






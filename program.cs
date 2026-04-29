public class Program
{
    public bool HasCycle(ListNode head)
    {
        var map = new Dictionary<ListNode, int>();
        int index = 0;
        var current = head;
        while (current != null)
        {
            if (current.next != null && map.ContainsKey(current.next))
            {
                return true;
            }
            else
            {
                map[current] = index;
                index++;
            }
            current = current.next;
        }
        return false;
    }
}






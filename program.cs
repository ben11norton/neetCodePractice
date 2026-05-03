public class Program
{
    public bool HasCycle(ListNode head)
    {
        var map = new Dictionary<ListNode, int>();
        int nodeIndex = 0;
        var current = head;
        while (current != null)
        {
            if (current.next != null && map.ContainsKey(current.next))
            {
                return true;
            }
            else
            {
                map[current] = nodeIndex;
                nodeIndex++;
            }
            current = current.next;
        }
        return false;
    }
}






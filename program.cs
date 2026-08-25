public class Program
{
    public ListNode ReverseList(ListNode head)
    {
        ListNode nextNode = null;
        var current = head;
        var p = current;
        while (current != null)
        {
            if (nextNode == null)
            {
                current = current.next;
                p.next = null;
            }
            if (current != null)
            {
                nextNode = current.next;
                current.next = p;
            }
            if (nextNode != null)
            {
                p = current;
                current = nextNode;
            }
            else if (current != null)
            {
                head = current;
                current = nextNode;
            }
            else
            {
                head = p;
            }
        }
        return head;
    }
}






public class Program
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null)
        {
            return head;
        }
        var stack = new Stack<ListNode>();
        var current = head;
        while (current != null)
        {
            stack.Push(current);
            current = current.next;
        }
        var reversedHead = stack.Pop();
        var reversedListNode = reversedHead;
        while (stack.Count > 0)
        {
            reversedListNode.next = stack.Pop();
            reversedListNode = reversedListNode.next;
        }
        reversedListNode.next = null;
        return reversedHead;
    }
}

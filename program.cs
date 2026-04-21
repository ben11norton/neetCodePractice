public class Program
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var map = new Dictionary<int, ListNode>();
        int nodeIndex = 0;
        int endingIndex = 0;
        ListNode current = head;
        while (current != null)
        {
            map[nodeIndex] = current;
            current = current.next;
            if (current == null)
            {
                endingIndex = nodeIndex;
            }
            else
            {
                nodeIndex++;
            }
        }
        var tailNode = map[endingIndex];
        var targetIndex = (endingIndex + 1) - n;
        var targetNode = map[targetIndex];
        if (targetNode == head)
        {
            if (targetNode.next == null)
            {
                return null;
            }
            else
            {
                return targetNode.next;
            }
        }
        var previousIndex = endingIndex - n;
        if (previousIndex < 0)
        {
            return null;
        }
        else
        {
            var previousNode = map[previousIndex];
            if (tailNode != targetNode)
            {
                previousNode.next = targetNode.next;
            }
            else
            {
                previousNode.next = null;
            }
        }
        return head;
    }
}






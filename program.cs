public class Program
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var map = new Dictionary<int, ListNode>();
        var index = 0;
        var current = head;
        while (current != null)
        {
            map[index] = current;
            index++;
            current = current.next;
        }
        // map [0: 1]
        var listLength = index; // 1
        var nodeToRemoveIndex = listLength - n;// 0
        var previousNodeIndex = nodeToRemoveIndex - 1;
        if (previousNodeIndex >= 0)
        {
            var previousNode = map[nodeToRemoveIndex - 1];
            if (nodeToRemoveIndex + 1 > listLength - 1)
            {
                previousNode.next = null;
            }
            else
            {
                var nodeAfter = map[nodeToRemoveIndex + 1];
                previousNode.next = nodeAfter;
            }
        }
        else
        {
            if (nodeToRemoveIndex + 1 <= listLength - 1)
            {
                var nodeAfter = map[nodeToRemoveIndex + 1];
                head = nodeAfter;
            }
            else
            {
                return null;
            }
        }
        return head;
    }
}






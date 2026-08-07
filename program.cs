public class Program
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var c1 = list1;
        var c2 = list2;
        ListNode c1Previous = null;

        while (c1 != null && c2 != null)
        {
            if (c1.val >= c2.val)
            {
                var mergeNode = c2;
                c2 = c2.next;
                if (c1Previous != null)
                {
                    c1Previous.next = mergeNode;
                }
                mergeNode.next = c1;
                if (c1 == list1)
                {
                    list1.head = mergeNode;
                }
                c1 = c1.next;

            }
            else if (c1.val < c2.val)
            {
                var c1Next = c1.next;
                var mergeNode = c2;
                c2 = c2.next;
                mergeNode.next = null;
                c1.next = mergeNode;
                mergeNode.next = c1Next;
                c1Previous = mergeNode;
                c1 = c1Next;
            }
        }
        return list1 != null ? list1 : list2;
    }
}






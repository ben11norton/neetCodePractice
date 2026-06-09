public class Program
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var current1 = list1;
        var current2 = list2;
        ListNode previous = null;
        while (current1 != null && current2 != null)
        {
            var current2Next = current2.next;
            if (current2.val <= current1.val)
            {
                current2.next = current1;
                if (previous != null)
                {
                    previous.next = current2;
                    previous = previous.next;
                }
                else
                {
                    list1 = current2;
                    previous = list1;
                }
                current2 = current2Next;
            }
            else
            {
                if (current1.next == null)
                {
                    current1.next = current2;
                    break;
                }
                else
                {
                    previous = current1;
                    current1 = current1.next;
                }
            }
        }
        return list1 != null ? list1 : list2;
    }
}






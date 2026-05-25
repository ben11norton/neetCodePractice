public class Program
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var curr1 = list1;
        var curr2 = list2;
        ListNode previous = null;
        while (curr2 != null && curr1 != null)
        {
            var next1 = curr1.next;
            var next2 = curr2.next;
            if (curr1.val >= curr2.val)
            {
                if (previous != null)
                {
                    previous.next = curr2;
                }
                else
                {
                    list1 = curr2;
                }
                curr2.next = curr1;
                curr2 = next2;
            }
            else
            {
                previous = curr1;
                curr1 = next1;
            }
        }
        var head = list1 != null ? list1 : list2;
        return head;
    }
}






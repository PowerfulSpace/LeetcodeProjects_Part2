

ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
int k1 = 2;

ListNode head2 = new ListNode(0, new ListNode(1, new ListNode(2)));
int k2 = 4;

var a = RotateRight(head1, k1);
var b = RotateRight(head2, k2);


Console.ReadLine();

ListNode RotateRight(ListNode head, int k)
{
    if (head is null) return null;
    if (head.next is null) return head;

    ListNode first = head;
    ListNode last = new ListNode();
    int index = 0;

    while (first != null)
    {
        index++;
        if (first.next == null)
        {
            last = first;
            first.next = head;
            break;
        }
        first = first.next;
    }


    if (index >= k)
    {
        index = index - k;

        while (index > 0)
        {
            head = head.next;
            index--;
        }
    }
    else
    {
        return last;
    }

    return head;

}



public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

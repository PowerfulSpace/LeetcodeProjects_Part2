

ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
int k1 = 2;

ListNode head2 = new ListNode(0, new ListNode(1, new ListNode(2)));
int k2 = 4;

var a = RotateRight(head1, k1);
var b = RotateRight(head2, k2);


Console.ReadLine();

ListNode RotateRight(ListNode head, int k)
{
    if (head == null || k == 0)
        return head;

    ListNode newhead = null;
    ListNode tail = head;
    int size = 1;
    while (tail.next != null)
    {
        size++;
        tail = tail.next;
    }
    tail.next = head;
    k = k % size;
    for (int i = 0; i < size - k; i++)
    {
        tail = tail.next;
    }
    newhead = tail.next;
    tail.next = null;
    return newhead;

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

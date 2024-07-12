

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

    ListNode current = head;
    int total = 1;

    while (current.next != null)
    {
        current = current.next;
        total++;
    }

    int iterations = k % total;

    current = head;
    ListNode previous = current;

    for (int i = 0; i < iterations; i++)
    {
        while (current.next != null)
        {
            previous = current;
            current = current.next;
        }

        previous.next = null;
        current.next = head;
        head = current;
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

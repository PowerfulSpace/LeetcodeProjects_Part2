

ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
int k1 = 2;

RotateRight(head1, k1);


Console.ReadLine();

ListNode RotateRight(ListNode head, int k)
{
    ListNode left = head;
    ListNode newHead = new ListNode();

    while(k != 0)
    {
        k--;
        if (k == 0)
        {
            newHead = head;
        }
        head = head.next;
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

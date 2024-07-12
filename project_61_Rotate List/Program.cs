

ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
int k1 = 2;

ListNode head2 = new ListNode(0, new ListNode(1, new ListNode(2)));
int k2 = 4;

RotateRight(head1, k1);
RotateRight(head2, k2);


Console.ReadLine();

ListNode RotateRight(ListNode head, int k)
{
    ListNode first = head;
    ListNode last = new ListNode();
    int index = 0;

    while(first != null)
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

    if(index >= k)
    {
        int skip = Math.Abs(index - k);

        while (skip > 0)
        {
            head = head.next;
            skip--;
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

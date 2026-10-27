/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummy = new ListNode(0);

        dummy.next = head;

        ListNode l = head;
        int len = 0;

        while(l != null)
        {
            len = len + 1;
            l = l.next;
        }

        int d = len - n + 1;
        
        ListNode prev = dummy, curr = head;
        int i = 0;

        while(i < (d - 1))
        {
            curr = curr.next;
            prev = prev.next;
            i = i + 1;
        }

        prev.next = prev.next.next;

        return dummy.next;
    }
}

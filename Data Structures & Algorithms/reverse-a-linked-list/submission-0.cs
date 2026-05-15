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
    public ListNode ReverseList(ListNode head) {
        ListNode temp = null;
        ListNode dumb = head;
        while(dumb!=null){
            ListNode t = dumb.next;
            dumb.next = temp;
            temp = dumb;
            dumb = t;
        }
        return temp;
    }
}

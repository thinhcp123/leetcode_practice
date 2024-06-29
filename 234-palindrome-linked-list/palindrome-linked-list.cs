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
    public bool IsPalindrome(ListNode head) {
        var fast =head;
        var slow = head;
        
        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode L = head;
        var R = reversal(slow);

        while(R!=null){
            if(L.val == R.val){
                L = L.next;
                R = R.next;
            }else {
                return false;
            }
        }
        return true;
    }
    private ListNode reversal(ListNode head){
        ListNode pre = null,cur = head;
        while(cur != null){
            ListNode temp = cur.next;
            cur.next = pre;
            pre = cur;
            cur = temp;
        }
        return pre;
    }
}
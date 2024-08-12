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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        string l11 = "";
        string l22 = "";

        while (l1 != null) {
            l11 += l1.val;
            l1 = l1.next;
        }
        while (l2 != null) {
            l22 += l2.val;
            l2 = l2.next;
        }

        char[] l1rArray = l11.ToCharArray();
        Array.Reverse(l1rArray);
        string l1r = new string(l1rArray);

        char[] l2rArray = l22.ToCharArray();
        Array.Reverse(l2rArray);
        string l2r = new string(l2rArray);

        // BigInteger kullanarak sayıları topluyoruz
        BigInteger number1 = BigInteger.Parse(l1r);
        BigInteger number2 = BigInteger.Parse(l2r);
        BigInteger sum = number1 + number2;

        string sumStr = sum.ToString();
        char[] sumArray = sumStr.ToCharArray();
        Array.Reverse(sumArray);

        ListNode dummy = new ListNode(0);
        ListNode current = dummy;

        foreach (char c in sumArray) {
            current.next = new ListNode(int.Parse(c.ToString()));
            current = current.next;
        }

        return dummy.next;
    }
}

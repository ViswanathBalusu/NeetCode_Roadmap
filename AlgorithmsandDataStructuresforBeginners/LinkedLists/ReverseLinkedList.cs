//Link: https://leetcode.com/problems/reverse-linked-list/submissions/1530509522/

namespace LeetCodeHunt.AlgorithmsandDataStructuresforBeginners.LinkedLists
{

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

    public class ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head  == null || head.next == null)
            {
                return head;
            }

            ListNode prev = null;
            ListNode curr = head;

            while (curr != null)
            {
                var temp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = temp;
            }

            return prev;

        }
    }

    public class ReverseLinkedList1
    {
        // Doubtful
        public ListNode ReverseList(ListNode head)
        {
            if ( head == null)
            {
                return head;
            }

            var newHead = head;

            if (newHead.next != null){
                newHead = ReverseList(head.next);
                head.next.next = head;
            }

            head.next = null;

            return newHead;

        }
    }
}

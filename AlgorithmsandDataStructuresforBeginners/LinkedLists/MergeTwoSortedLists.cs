﻿namespace LeetCodeHunt.AlgorithmsandDataStructuresforBeginners.LinkedLists
{

    public class MergeTwoSortedLists1
    {
        //Link: https://leetcode.com/problems/merge-two-sorted-lists/submissions/1531841741/
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new();
            ListNode node = dummy;


            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val) 
                {
                    node.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    node.next = list2;
                    list2 = list2.next;
                }
                node = node.next;

            }

            if (list1 != null)
            {
                node.next = list1;
            }
            else
            {
                node.next = list2;
            }

            return dummy.next;
        }
    }

    public class MergeTwoSortedLists2
    {
        //Link: https://leetcode.com/problems/merge-two-sorted-lists/submissions/1531840986/
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null)
            {
                return list2;
            }

            if (list2 == null)
            {
                return list1;
            }

            if(list1.val < list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }
    }
}

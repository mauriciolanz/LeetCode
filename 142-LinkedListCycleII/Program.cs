using System;

/// <summary>
/// Day 4 - LinkedList
/// https://leetcode.com/study-plan/leetcode-75
/// 142. Linked List Cycle II
/// https://leetcode.com/problems/linked-list-cycle-ii/
/// </summary>
namespace LinkedListCycleII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            var head = new ListNode(1, new ListNode()
            {
                val = 3,
                next = new ListNode()
                {
                    val = 2,
                    next = new ListNode()
                    {
                        val = 0,
                        next = new ListNode()
                        {
                            val = 4
                        }
                    }
                }
            });

            // Run
            ListNode result = DetectCycle(head);

            // Output
            // Too much work for creating the test verification. Tested in the leetcode website instead.
        }

        public static ListNode DetectCycle(ListNode head)
        {
            if (head == null)
                return null;

            var intersect = GetIntersect(head);

            if(intersect == null)
                return null;

            ListNode node1 = head;
            ListNode node2 = intersect;

            while (node1 != node2)
            {
                node1 = node1.next;
                node2 = node2.next;
            }

            return node1;
        }

        private static ListNode GetIntersect(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    return slow;
                }
            }

            return null;
        }

        // My first solution
        //public static ListNode DetectCycle(ListNode head)
        //{
        //    var listNodes = new HashSet<ListNode>();

        //    while(head != null)
        //    {
        //        if(listNodes.Contains(head))
        //            return head;

        //        listNodes.Add(head);
        //        head = head.next;
        //    }

        //    return null;
        //}
    }

    /// <summary>
    /// Definition for singly-linked list.
    /// </summary>
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
}
using System;

/// <summary>
/// Day 4 - LinkedList
/// https://leetcode.com/study-plan/leetcode-75
/// 876. Middle of the Linked List
/// https://leetcode.com/problems/middle-of-the-linked-list/
/// </summary>
namespace MiddleOfTheLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            var head = new ListNode(1, new ListNode()
            {
                val = 2,
                next = new ListNode()
                {
                    val = 3,
                    next = new ListNode()
                    {
                        val = 4,
                        next = new ListNode()
                        {
                            val = 5,
                            next = new ListNode()
                            {
                                val = 6
                            }
                        }
                    }
                }
            });

            var expectedResult = "[5, 4, 3, 2, 1]";

            // Run
            ListNode result = MiddleNode(head);

            // Output
            Console.WriteLine("Expected result: {0}", expectedResult);
            Console.WriteLine("Real result:     {0}", result.ToString());
            Console.ReadLine();
        }

        public static ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            return slow;
        }

        // My first solution
        //public static ListNode MiddleNode(ListNode head)
        //{
        //    int count = 0;
        //    ListNode currentNode = head;

        //    while (currentNode != null)
        //    {
        //        currentNode = currentNode.next;
        //        count++;
        //    }

        //    // Gets the middle index
        //    int middle = (count / 2) + 1;

        //    // Restart variables so we can loop over it again
        //    currentNode = head;
        //    count = 0;

        //    while (currentNode != null)
        //    {
        //        count++;

        //        if (count == middle)
        //        {
        //            return currentNode;
        //        }

        //        currentNode = currentNode.next;
        //    }

        //    return head;
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
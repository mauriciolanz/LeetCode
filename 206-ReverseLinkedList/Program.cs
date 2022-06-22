using System;
using System.Text;

/// <summary>
/// Day 3 - LinkedList
/// https://leetcode.com/study-plan/leetcode-75
/// 206. Reverse Linked List
/// https://leetcode.com/problems/reverse-linked-list/
/// </summary>
namespace ReverseLinkedList
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
                            val = 5
                        }
                    }
                }
            });

            var expectedResult = "[5, 4, 3, 2, 1]";

            // Run
            ListNode result = ReverseList(head);

            // Output
            Console.WriteLine("Expected result: {0}", expectedResult);
            Console.WriteLine("Real result:     {0}", result.ToString());
            Console.ReadLine();
        }
        public static ListNode ReverseList(ListNode head)
        {
            //TODO retry this task because I needed to see videos to get to the result
            ListNode previousNode = null;
            ListNode currentNode = head;

            while(currentNode != null)
            {
                ListNode nextNode = currentNode.next;
                currentNode.next = previousNode;
                previousNode = currentNode;
                currentNode = nextNode;
            }

            return previousNode;
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

            public override string ToString()
            {
                var result = new StringBuilder();

                if (this != null)
                {
                    result.Append("[");
                    result.Append(this.val);

                    var nextNode = this.next;
                    while (nextNode != null)
                    {
                        result.Append(" ," + nextNode.val);
                        nextNode = nextNode.next;
                    }

                    result.Append("]");
                    return result.ToString();
                }
                else
                {
                    return "[ ]";
                }
            }
        }
    }
}

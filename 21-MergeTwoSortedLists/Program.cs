using System;
using System.Text;

/// <summary>
/// Day 3 - LinkedList
/// https://leetcode.com/study-plan/leetcode-75
/// 21. Merge Two Sorted Lists
/// https://leetcode.com/problems/merge-two-sorted-lists/
/// </summary>
namespace MergeTwoSortedLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            var list1 = new ListNode(1, new ListNode() {
                val = 2,
                next = new ListNode()
                {
                    val = 4
                }
            });

            var list2 = new ListNode(1, new ListNode()
            {
                val = 3,
                next = new ListNode()
                {
                    val = 4
                }
            });

            var expectedResult = "[1, 1, 2, 3, 4, 4]";

            // Run
            ListNode result = MergeTwoLists(list1, list2);

            // Output
            Console.WriteLine("Expected result: {0}", expectedResult);
            Console.WriteLine("Real result:     {0}", result.ToString());
            Console.ReadLine();
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {            
            ListNode headNode = null;
            ListNode currentNode = new ListNode();

            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    currentNode.val = list2.val;
                    list2 = list2.next;
                }
                else if (list2 == null)
                {
                    currentNode.val = list1.val;
                    list1 = list1.next;
                }
                else
                {
                    if(list1.val < list2.val)
                    {
                        currentNode.val = list1.val;
                        list1 = list1.next;
                    }
                    else
                    {
                        currentNode.val = list2.val;
                        list2 = list2.next;
                    }
                }

                if(headNode == null)
                {
                    headNode = currentNode;
                }

                if (list1 != null || list2 != null)
                {
                    currentNode.next = new ListNode();
                    currentNode = currentNode.next;
                }
            }

            return headNode;
        }
    }

    /// <summary>
    /// Definition for singly-linked list.
    /// </summary>
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) 
        {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            if(this != null)
            {
                result.Append("[");
                result.Append(this.val);

                var nextNode = this.next;
                while(nextNode != null)
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
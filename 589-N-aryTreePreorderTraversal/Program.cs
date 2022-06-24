using System;

/// <summary>
/// Day 6 - Tree
/// https://leetcode.com/study-plan/leetcode-75
/// 589. N-ary Tree Preorder Traversal
/// https://leetcode.com/problems/n-ary-tree-preorder-traversal/
/// </summary>
namespace NaryTreePreorderTraversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            var input = CreateTree();

            // Run
            var result = Preorder(input);

            // Output
            Console.WriteLine("Expected output: [ 1,3,5,6,2,4 ]");
            Console.WriteLine("Real output:     [ {0} ]", string.Join<int>(",", result));

            Console.ReadLine();
        }

        private static Node CreateTree()
        {
            var root = new Node();
            root.val = 1;
            root.children = new List<Node>();

            var firstLevel1 = new Node();
            firstLevel1.val = 3;
            firstLevel1.children = new List<Node>();

            var secondLevel1 = new Node();
            secondLevel1.val = 5;

            var secondLevel2 = new Node();
            secondLevel2.val = 6;

            firstLevel1.children.Add(secondLevel1);
            firstLevel1.children.Add(secondLevel2);

            var firstLevel2 = new Node();
            firstLevel2.val = 2;

            var firstLevel3 = new Node();
            firstLevel3.val = 4;

            root.children.Add(firstLevel1);
            root.children.Add(firstLevel2);
            root.children.Add(firstLevel3);

            return root;
        }

        // Stack solution
        public static IList<int> Preorder(Node root)
        {
            if (root == null) return new List<int>();

            var list = new List<int>();
            var stack = new Stack<Node>();

            stack.Push(root);
            while (stack.Count > 0)
            {
                var node = stack.Pop();
                list.Add(node.val);

                if(node.children != null)
                {
                    foreach (var child in node.children.Reverse())
                        stack.Push(child);
                }
            }

            return list;
        }

        // Recursion solution
        //public static IList<int> Preorder(Node root)
        //{
        //    var list = new List<int>();

        //    if(root != null)
        //    {
        //        list.Add(root.val);
        //        Recursion(root, list);
        //    }

        //    return list;
        //}

        //private static void Recursion(Node parent, List<int> list)
        //{
        //    if (parent.children != null)
        //    {
        //        foreach (var child in parent.children)
        //        {
        //            list.Add(child.val);
        //            Recursion(child, list);
        //        }
        //    }
        //}
    }

    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
}
using System;

/// <summary>
/// Day 8 - Binary Search Tree
/// https://leetcode.com/study-plan/leetcode-75
/// 98. Validate Binary Search Tree
/// https://leetcode.com/problems/validate-binary-search-tree/
/// </summary>
namespace ValidateBinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            var input = CreateTree();

            // Run
            bool result = IsValidBST(input);

            // Output
            Console.WriteLine("Expected result: {0}", false);
            Console.WriteLine("Real result:     {0}", result.ToString());
            Console.ReadLine();
        }

        private static TreeNode CreateTree()
        {
            return new TreeNode(5)
            {
                left = new TreeNode(4),
                right = new TreeNode(6)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(7)
                }
            };
        }

        public static bool IsValidBST(TreeNode root)
        {
            var stack = new Stack<TreeNode>();
            int? left_child_val = null;

            while (stack.Count > 0 || root != null)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }

                root = stack.Pop();
                if (root.val <= left_child_val && left_child_val != null) return false;

                left_child_val = root.val;
                root = root.right;
            }

            return true;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }        
}
using System;

/// <summary>
/// Day 6 - Tree
/// https://leetcode.com/study-plan/leetcode-75
/// 102. Binary Tree Level Order Traversal
/// https://leetcode.com/problems/binary-tree-level-order-traversal/
/// </summary>
namespace BinaryTreeLevelOrderTraversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            var input = CreateTree();

            // Run
            var result = LevelOrder(input);

            // Output
            // Tested on leetcode website
        }

        private static TreeNode CreateTree()
        {
            var tree = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4)
                },
                right = new TreeNode(3)
                {
                    right = new TreeNode(5)
                }
            };

            return tree;
        }

        // Solution with Recursion
        //public static IList<IList<int>> LevelOrder(TreeNode root)
        //{
        //    if(root == null) return new List<IList<int>>();
                        
        //    var orderedList = new List<IList<int>>();
        //    var firstLevelList = new List<int>() { root.val };
        //    orderedList.Add(firstLevelList);

        //    Recursion(root, orderedList, 1);

        //    return orderedList;
        //}

        //private static void Recursion(TreeNode treeNode, List<IList<int>> orderedList, int listIndex)
        //{
        //    var levelList = new List<int>();

        //    if(treeNode.left != null)
        //    {
        //        levelList.Add(treeNode.left.val);
        //    }

        //    if (treeNode.right != null)
        //    {
        //        levelList.Add(treeNode.right.val);
        //    }

        //    if(levelList.Count > 0)
        //    {
        //        if (orderedList.Count > listIndex)
        //        {                    
        //            for(int i = 0;i < levelList.Count; i++) 
        //                orderedList[listIndex].Add(levelList[i]);
        //        }
        //        else
        //        {
        //            orderedList.Add(levelList);
        //        }
        //    }

        //    if (treeNode.left != null)
        //    {
        //        Recursion(treeNode.left, orderedList, listIndex + 1);
        //    }

        //    if (treeNode.right != null)
        //    {
        //        Recursion(treeNode.right, orderedList, listIndex + 1);
        //    }
        //}

        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            var levels = new List<IList<int>>();
            if (root == null) return levels;

            int currentLevel = 0;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                levels.Add(new List<int>());

                int levelLength = queue.Count;

                for (int i = 0; i < levelLength; i++)
                {
                    TreeNode currentNode = queue.Dequeue();
                    levels[currentLevel].Add(currentNode.val);

                    if (currentNode.left != null)
                        queue.Enqueue(currentNode.left);

                    if (currentNode.right != null)
                        queue.Enqueue(currentNode.right);

                }

                currentLevel++;
            }

            return levels;
        }
    }

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) 
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
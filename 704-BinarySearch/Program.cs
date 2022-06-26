
/// <summary>
/// Day 7 - Binary Search
/// https://leetcode.com/study-plan/leetcode-75
/// 704. Binary Search
/// https://leetcode.com/problems/binary-search/
/// </summary>
/// 
namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            var input = new int[] { -1, 0, 3, 5, 9, 12 };

            // Run
            int result = Search(input, 9);

            // Output
            Console.WriteLine("Expected result: {0}", 4);
            Console.WriteLine("Real result:     {0}", result.ToString());
            Console.ReadLine();
        }

        public static int Search(int[] nums, int target)
        {
            int pivot;
            int left = 0;
            int right = nums.Length - 1;

            while(left <= right)
            {
                pivot = left + (right - left) / 2;
                if(target == nums[pivot])
                {
                    return pivot;
                }
                else if(target < nums[pivot])
                {
                    right = pivot-1;
                }
                else
                {
                    left = pivot + 1;
                }
            }

            return -1;
        }
    }
}
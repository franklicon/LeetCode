using Microsoft.VisualBasic;

namespace LeetCode.Solutions.Easy
{
    public static class SingleNumber
    {
        /// <summary>
        /// Time complexity O(n).
        /// Space complexity O(1).
        /// </summary>
        /// <param name="nums"></param>
        public static int SolutionA(int[] nums)
        {
            var result = 0;
            foreach(var num in nums)
            {
                result ^= num;
            }
            return result;
        }

        /// <summary>
        /// Time complexity O(n).
        /// Space complexity O(n).
        /// </summary>
        /// <param name="nums"></param>
        public static int SolutionB(int[] nums)
        {
            var hashSet = new HashSet<int>();
            for(var i = 0; i < nums.Length; i++)
            {
                if (hashSet.Contains(nums[i]))
                {
                    hashSet.Remove(nums[i]);
                }
                else
                {
                    hashSet.Add(nums[i]);
                }
            }
            return hashSet.First();
        }
    }
}

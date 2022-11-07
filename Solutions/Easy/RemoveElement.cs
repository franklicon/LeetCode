namespace LeetCode.Solutions.Easy
{
    public static class RemoveElement
    {
        public static int Solution(int[] nums, int val)
        {
            var n = nums.Length - 1;
            var indexToInsert = 0;
            for (var i = 0; i <= n; i++)
            {
                if (nums[i] != val)
                {
                    nums[indexToInsert] = nums[i];
                    indexToInsert++;
                }
            }
            return indexToInsert;
        }
    }
}

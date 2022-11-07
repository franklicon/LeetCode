namespace LeetCode.Solutions.Easy
{
    public static class RemoveDuplicatesFromSortedArray
    {
        public static int Solution(int[] nums)
        {
            var n = nums.Length - 1;
            var indexOfInsertion = 1;
            for (var i = 1; i <= n; i++)
            {
                if (nums[i] != nums[i - 1])
                {
                    nums[indexOfInsertion] = nums[i];
                    indexOfInsertion++;

                }
            }
            return indexOfInsertion;
        }
    }
}


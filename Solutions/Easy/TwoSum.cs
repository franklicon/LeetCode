namespace LeetCode.Solutions.Easy
{
    public static class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
            var n = nums.Length - 1;
            var numsDictionary = new Dictionary<int, int>();

            for(var i = 0; i <= n; i++)
            {
                var num = target - nums[i];

                if (numsDictionary.ContainsKey(num))
                {
                    return new int[] { i, numsDictionary[num] };
                }
                else
                {
                    numsDictionary.TryAdd(nums[i], i);
                }
            }

            return Array.Empty<int>();
        }
    }
}

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

                if (numsDictionary.TryGetValue(num, out var value))
                {
                    return [i, value];
                }

                numsDictionary.TryAdd(nums[i], i);
            }

            return [];
        }
    }
}

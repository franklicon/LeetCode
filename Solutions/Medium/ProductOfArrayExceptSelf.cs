namespace LeetCode.Solutions.Medium
{
    public static class ProductOfArrayExceptSelf
    {
        public static int[] SolutionA(int[] nums)
        {
            var n = nums.Length - 1;
            var prefix = 1;
            var postfix = 1;
            var result = new int[n + 1];

            for(var i = 0; i <= n; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            for(var i = n; i >= 0; i--)
            {
                result[i] *= postfix;
                postfix *= nums[i];
            }

            return result;
        }

        public static int[] SolutionB(int[] nums)
        {
            var n = nums.Length - 1;
            var result = new int[n + 1];
            var prefixArray = new int[n + 1];
            var postfixArray = new int[n + 1];
            var prefix = 1;
            var postfix = 1;

            for(var i = 0; i <= n; i++)
            {
                prefixArray[i] = prefix;
                prefix *= nums[i];
            }

            for(var i = n; i >= 0; i--)
            {
                postfixArray[i] = postfix;
                postfix *= nums[i];
            }

            for(var i = 0; i <= n; i++)
            {
                result[i] = prefixArray[i] * postfixArray[i];
            }

            return result;
        }
    }
}

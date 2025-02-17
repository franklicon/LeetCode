namespace LeetCode.Solutions.Medium
{
    public static class ProductOfArrayExceptSelf
    {
        public static int[] SolutionA(int[] nums)
        {
            var result = new int[nums.Length];
            var aux = 1;
            for(var i = 0; i < nums.Length; i++)
            {
                result[i] = aux;
                aux *= nums[i];
            }
            
            aux = 1;
            for(var i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= aux;
                aux *= nums[i];
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

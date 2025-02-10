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

        public static int SolutionB(int[] nums)
        {
            if(nums.Length == 1)
                return 1;

            var k = 0;
            for(var i = 1; i < nums.Length; i++)
            {
                while(i < nums.Length && nums[i] == nums[k])
                {
                    i++;
                }
                if(i < nums.Length && nums[k] != nums[i])
                    nums[++k] = nums[i];
            }
        
            return k+1;
        }
    }
}


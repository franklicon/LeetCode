namespace LeetCode.Solutions.Easy
{
    public static class ContainsDuplicate
    {
        public static bool Solution(int[] nums)
        {
            var hashSet = new HashSet<int>();
            foreach (var num in nums)
            {
                if (!hashSet.Add(num))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

namespace LeetCode.Solutions.Easy;

public static class MissingNumber
{
    public static int Solution(int[] nums)
    {
        var n = nums.Length;
        var gaussSum = n * (n + 1) / 2;
        var numsSum = 0;
        for(var i  = 0; i < n; i++)
        {
            numsSum += nums[i];
        }
        return gaussSum - numsSum;
    }
}
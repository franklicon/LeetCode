namespace LeetCode.Solutions.Easy;

public static class MoveZeros
{
    public static void Solution(int[] nums)
    {
        var indexOfInsertion = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) continue;
            (nums[indexOfInsertion], nums[i]) = (nums[i], nums[indexOfInsertion]);
            indexOfInsertion++;
        }
    }
}
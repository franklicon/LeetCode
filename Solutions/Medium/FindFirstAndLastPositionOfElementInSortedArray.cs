namespace Solutions.Medium;

public static class FindFirstAndLastPositionOfElementInSortedArray
{
    public static int[] Solution(int[] nums, int target)
    {
        var result = new int[2];
        result[0] = FindIndex(nums, target, true);
        result[1] = FindIndex(nums, target);
        return result;
    }

    private static int FindIndex(int[] nums, int target, bool isFirst = false)
    {
        var left = 0;
        var right = nums.Length - 1;
        while (left <= right)
        {
            var mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                if (isFirst)
                {
                    if (mid == 0 || nums[mid - 1] != target)
                        return mid;
                    right = mid - 1;
                }
                else
                {
                    if (mid == nums.Length - 1 || nums[mid + 1] != target)
                        return mid;
                    left = mid + 1;
                }
            }
            else if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return -1;
    }
}
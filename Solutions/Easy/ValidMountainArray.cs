namespace LeetCode.Solutions.Easy;

public static class ValidMountainArray
{
    public static bool Solution(int[] arr)
    {
        if (arr.Length < 3)
            return false;

        var i = 0;
        var n = arr.Length - 1;
        
        while (i < n && arr[i] < arr[i + 1])
            i++;

        if (i == n || i == 0)
            return false;
        
        while (i < n && arr[i] > arr[i + 1])
            i++;
        
        return i == arr.Length - 1;
    }
}
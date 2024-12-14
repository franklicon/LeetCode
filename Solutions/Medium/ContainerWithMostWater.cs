namespace Solutions.Medium
{
    public static class ContainerWithMostWater
    {
        public static int Solution(int[] height)
        {
            var maxArea = 0;
            var left = 0;
            var right = height.Length - 1;
            while (left < right)
            {
                var currentArea = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea, currentArea);
                
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return maxArea;
        }
    }
}

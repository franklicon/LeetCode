namespace Solutions.Medium
{
    public static class ContainerWithMostWater
    {
        public static int Solution(int[] height)
        {
            var a = 0;
            var b = height.Length - 1;
            var maxArea = 0;
            while (a < b)
            {
                var area = Math.Min(height[a], height[b]) * (b - a);
                if (area > maxArea)
                {
                    maxArea = area;
                }
                if(height[a] < height[b])
                {
                    a++;
                }
                else
                {
                    b--;
                }
            }
            return maxArea;
        }
    }
}

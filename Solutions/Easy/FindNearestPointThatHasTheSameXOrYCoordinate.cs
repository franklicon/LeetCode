namespace LeetCode.Solutions.Easy
{
    public static class FindNearestPointThatHasTheSameXOrYCoordinate
    {
        public static int Solution(int x, int y, int[][] points)
        {
            var n = points.Length - 1; 
            var minDistance = int.MaxValue;
            var index = -1;
            for(var i = 0; i <= n; i++)
            {
                if (points[i][0] == x || points[i][1] == y)
                {
                    var manhattanDistance = ManhattanDistance(x, y, points[i][0], points[i][1]);
                    if (manhattanDistance < minDistance)
                    {
                        minDistance = manhattanDistance;
                        index = i;
                    }
                }
            }

            return index;
        }

        private static int ManhattanDistance(int x1, int y1, int x2, int y2)
        {
            return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
        }
    }
}

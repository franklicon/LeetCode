namespace Solutions.Medium
{
    public static class BoatsToSavePeople
    {   
        public static int Solution(int[] people, int limit)
        {
            Array.Sort(people);
            var left = 0;
            var right = people.Length - 1;
            var boats = 0;
            while (left <= right)
            {
                if (people[left] + people[right] <= limit)
                {
                    left++;
                    right--;
                }
                else
                {
                    right--;
                }
                boats++;
            }
            return boats;
        }
    }
}

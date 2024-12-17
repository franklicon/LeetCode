namespace Solutions.Medium
{
    public static class BoatsToSavePeople
    {   
        public static int Solution(int[] people, int limit)
        {
            var boats = 0;
            var left = 0;
            var right = people.Length - 1;
            Array.Sort(people);

            while (left <= right)
            {
                if (people[left] + people[right] <= limit)
                {
                    left++;
                }
                
                right--;
                boats++;
            }
            
            return boats;
        }
    }
}

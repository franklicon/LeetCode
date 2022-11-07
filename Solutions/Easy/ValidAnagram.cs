namespace LeetCode.Solutions.Easy
{
    public static class ValidAnagram
    {
        public static bool SolutionA(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            var charList = s.ToList();

            foreach (var c in t)
            {
                if (!charList.Contains(c))
                {
                    return false;
                }
                else
                {
                    charList.Remove(c);
                }
            }

            return true;
        }

        public static bool SolutionB(string s, string t)
        {
            var sortedS = String.Concat(s.OrderBy(c => c));
            var sortedT = String.Concat(t.OrderBy(c => c));
            return sortedS == sortedT;
        }
    }
}

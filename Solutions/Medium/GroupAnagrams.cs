namespace LeetCode.Solutions.Medium
{
    public static class GroupAnagrams
    {
        public static IList<IList<string>> Solution(string[] strs)
        {
            var dic = new Dictionary<string, IList<string>>();
            
            foreach(var s in strs)
            {
                var sortedS = string.Concat(s.OrderBy(c => c));
                if (dic.ContainsKey(sortedS))
                {
                    dic[sortedS].Add(s);
                }
                else
                {
                    dic.Add(sortedS, new List<string> { s });
                }
            }
                
            return dic.Values.ToList();
        }
    }
}

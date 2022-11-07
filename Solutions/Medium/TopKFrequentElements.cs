namespace LeetCode.Solutions.Medium
{
    public static class TopKFrequentElements
    {
        public static int[] SolutionA(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();
            var array = new List<int>[nums.Length + 1];
            var result = new List<int>();

            foreach (var num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic.Add(num, 1);
                }
            }

            foreach(var item in dic)
            {
                if (array[item.Value] != null)
                {
                    array[item.Value].Add(item.Key);
                }
                else
                {
                    array[item.Value] = new List<int> { item.Key };
                }
            }

            for(var i = array.Length - 1; i > 0 ; i--)
            {
                if (array[i] != null)
                {
                    foreach (var n in array[i])
                    {
                        result.Add(n);
                        if (result.Count == k)
                        {
                            return result.ToArray();
                        }
                    }
                }
                
            }

            return Array.Empty<int>();
        }

        public static int[] SolutionB(int[] nums, int k)
        {
            var dic = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (dic.ContainsKey(num))
                {
                    dic[num]++;
                }
                else
                {
                    dic.Add(num, 1);
                }
            }

            return dic.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
        }
    }
}

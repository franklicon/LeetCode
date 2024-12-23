namespace Solutions.Medium;

public static class LongestSubstringWithoutRepeatingCharacters
{
    public static int Solution(string s)
    {
        if (s.Length == 0)
            return 0;
        
        var chars = new Dictionary<char, int>();
        var left = 0;
        var right = 0;
        var maxLength = 1;

        while (right < s.Length)
        {
            if (!chars.ContainsKey(s[right]))
            {
                chars.Add(s[right], right);
            }
            else
            {
                left = Math.Max(left, chars[s[right]] + 1);
                chars[s[right]] = right;
            }
            maxLength = Math.Max(maxLength, right - left + 1);
            right++;
        }

        return maxLength;
    }
}
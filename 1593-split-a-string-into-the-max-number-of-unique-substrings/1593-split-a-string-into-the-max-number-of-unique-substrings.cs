public class Solution 
{
    private int maxLen;
    private void Recurse(string s, int idx, HashSet<string> set, StringBuilder sb)
    {
        if (idx >= s.Length)
        {
            maxLen = Math.Max(set.Count, maxLen);
            return;
        }

        sb.Append(s[idx]);
            
        var str = sb.ToString();

        Recurse(s, idx+1, set.ToHashSet(), new StringBuilder(str));

        if (!set.Contains(str))
        {
            set.Add(str);
            Recurse(s, idx+1, set.ToHashSet(), new StringBuilder());
        }
    }

    public int MaxUniqueSplit(string s) 
    {
        maxLen = 1;
        Recurse(s, 0, new HashSet<string>(), new StringBuilder());
        return maxLen;
    }
}
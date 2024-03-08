public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        int left = 0, max = 0;
        var set = new HashSet<int>();
        
        for(int right = 0; right < s.Length; right++)
        {
            while(set.Contains(s[right])) set.Remove(s[left++]);
            
            set.Add(s[right]);
            
            max = Math.Max(right-left+1, max);
        }
        
        return max;
    }
}
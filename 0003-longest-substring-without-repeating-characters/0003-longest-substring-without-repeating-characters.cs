public class Solution 
{
    public int LengthOfLongestSubstring(string s) 
    {
        int left = 0, max = 0;
        var map = new Dictionary<int, int>();
        
        for(int right = 0; right < s.Length; right++)
        {
            if(map.ContainsKey(s[right]) && left <= map[s[right]])
                left = map[s[right]]+1;
            else
                max = Math.Max(max, right - left + 1);
                
            map[s[right]] = right;
        }
        
        return max;
    }
}
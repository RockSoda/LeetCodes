public class Solution 
{
    public int LongestPalindrome(string s) 
    {
        var map = new Dictionary<char, int>();
        foreach(var c in s) map[c] = map.ContainsKey(c) ? map[c] + 1 : 1;
        
        int len = 0;
        bool isOddUsed = false;
        foreach(var kvp in map)
        {
            int freq = kvp.Value;
            if(freq % 2 == 1)
            {
                len += freq - (isOddUsed ? 1 : 0);
                if(!isOddUsed) isOddUsed = true;
            }
            else len += freq;
        }
        
        return len;
    }
}
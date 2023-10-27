public class Solution 
{
    public string LongestPalindrome(string s) 
    {
        if (s.Length < 2) return s;
        
        int start = 0;
        int maxLen = 0;
        
        int ExpandFromMiddle(int left, int right)
        {
            if(left > right) return 0;
            
            while(right < s.Length && left >= 0 && s[left] == s[right])
            {
                left--;
                right++;
            }
            
            return right - left - 1;
        }
        
        for(int i = 0; i < s.Length; i++)
        {
            int len1 = ExpandFromMiddle(i, i);
            int len2 = ExpandFromMiddle(i, i+1);
            int len = Math.Max(len1, len2);
            
            if(len > maxLen)
            {
                start = i - ((len - 1)/2);
                maxLen = len;
            }
        }
        
        return s.Substring(start, maxLen);
    }
}
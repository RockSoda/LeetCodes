public class Solution 
{
    public int MinimumLength(string s) 
    {
        int left = 0, right = s.Length - 1;
        
        while(left < right && s[left] == s[right])
        {
            while(left + 1 < s.Length && s[left] == s[left+1]) left++;
            while(right - 1 >= 0 && s[right] == s[right-1]) right--;
            
            if(left >= right) return 0;
            
            left++;
            right--;
        }
        
        return right - left + 1;
    }
}
public class Solution 
{
    public int NumberOfSubstrings(string s) 
    {
        var map = new int[]{ 0, 0, 0 };
        int left = 0, ans = 0;

        for(int right = 0; right < s.Length; right++)
        {
            map[s[right] - 'a']++;
            while(map['a'-'a'] > 0 && map['b'-'a'] > 0 && map['c'-'a'] > 0)
            {
                ans += s.Length - right;
                map[s[left++] - 'a']--;
            }
        }
        return ans;
    }
}
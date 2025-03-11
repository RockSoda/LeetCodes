public class Solution 
{
    public int NumberOfSubstrings(string s) 
    {
        var map = new int[]{ 0, 0, 0 };
        int left = 0, ans = 0;

        int GetIdx(char c) => c - 'a';

        for(int right = 0; right < s.Length; right++)
        {
            map[GetIdx(s[right])]++;
            while(map[GetIdx('a')] > 0 && map[GetIdx('b')] > 0 && map[GetIdx('c')] > 0)
            {
                ans += s.Length - right;
                map[GetIdx(s[left++])]--;
            }
        }
        return ans;
    }
}
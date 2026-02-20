public class Solution 
{
    public int CountBinarySubstrings(string s) 
    {
        int result = 0, curr = 1, prev = 0;
        for(int i = 1; i < s.Length; i++)
        {
            if(s[i] == s[i-1]) curr++;
            else
            {
                result += Math.Min(prev, curr);
                prev = curr;
                curr = 1;
            }
        }
        return result + Math.Min(prev, curr);
    }
}
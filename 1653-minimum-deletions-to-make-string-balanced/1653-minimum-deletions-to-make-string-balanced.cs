public class Solution 
{
    public int MinimumDeletions(string s) 
    {
        int ans = 0, count = 0;
        foreach(var c in s)
        {
            if (c == 'b') count++;
            else if (count > 0) 
            {
                ans++;
                count--;
            }
        }
        
        return ans;
    }
}
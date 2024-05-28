public class Solution 
{
    public int EqualSubstring(string s, string t, int maxCost) 
    {
        int len = s.Length, maxLen = 0, currLen = 0, currCost = 0, startIdx = 0;
        for(int i = 0; i < len; i++)
        {
            var diff = Math.Abs(s[i]-t[i]);
            currCost += diff;
            currLen++;
            
            while(currCost > maxCost)
            {
                currCost -= Math.Abs(s[startIdx]-t[startIdx]);
                startIdx++;
                currLen--;
            }
            
            if(currLen > maxLen) maxLen = currLen;
        }
        
        return maxLen;
    }
}
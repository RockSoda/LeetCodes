public class Solution 
{
    public int EqualSubstring(string s, string t, int maxCost) 
    {
        var len = s.Length;
        var costAry = new int[len];
        for(int i = 0; i < len; i++) costAry[i] = Math.Abs(s[i]-t[i]);
        
        int maxLen = 0, currLen = 0, currCost = 0, startIdx = 0;
        for(int i = 0; i < len; i++)
        {
            currCost += costAry[i];
            currLen++;
            
            while(currCost > maxCost)
            {
                currCost -= costAry[startIdx];
                startIdx++;
                currLen--;
            }
            
            if(currLen > maxLen) maxLen = currLen;
        }
        
        return maxLen;
    }
}
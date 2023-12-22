public class Solution 
{
    public int MaxScore(string s) 
    {
        var maxScore = 0;
        var currScore = s.Count(c => c == '1');
        
        for(int i = 1; i < s.Length; i++)
        {
            currScore += s[i-1] == '1' ? -1 : 1;
            
            maxScore = Math.Max(maxScore, currScore);
        }
        return maxScore;
    }
}
public class Solution 
{
    public int BestClosingTime(string customers) 
    {
        int maxScore = 0, score = 0, earliest = -1;
        
        for(int i = 0; i < customers.Length; i++)
        {
            score += customers[i] == 'Y' ? 1 : -1;
            if(score > maxScore)
            {
                maxScore = score;
                earliest = i;
            }
        }
        
        return earliest + 1;
    }
}
public class Solution 
{
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] workers) 
    {
        var len = profit.Length;
        
        Array.Sort(profit, difficulty);
        
        var output = 0;
        
        foreach(var worker in workers)
        {
            for(int i = len-1; i >= 0; i--)
            {
                if(difficulty[i] > worker) continue;
                
                output += profit[i];
                break;
            }
        }
        
        return output;
    }
}
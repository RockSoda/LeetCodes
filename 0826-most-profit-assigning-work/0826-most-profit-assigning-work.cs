public class Solution 
{
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] workers) 
    {
        var len = profit.Length;
        var output = 0;
        
        foreach(var worker in workers)
        {
            var currProf = 0;
            for(int i = len-1; i >= 0; i--)
            {
                if(difficulty[i] <= worker && profit[i] > currProf) currProf = profit[i];
            }
            output += currProf;
        }
        
        return output;
    }
}
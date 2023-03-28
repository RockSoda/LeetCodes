public class Solution 
{
    private int GetMin(int a, int b, int c) => Math.Min(Math.Min(a, b), c);
    
    private int Helper(int[] days, int[] costs, int index, int daysCovered, Dictionary<(int, int), int> memo)
    {
        if(index >= days.Length) return 0;
        
        if(memo.ContainsKey((index, daysCovered))) return memo[(index, daysCovered)];
        
        if(daysCovered >= days[index]) 
            memo[(index, daysCovered)] = Helper(days, costs, index+1, daysCovered, memo);
        else
        {
            int one = Helper(days, costs, index+1, days[index], memo) + costs[0];
            int seven = Helper(days, costs, index+1, days[index]+6, memo) + costs[1];
            int thirty = Helper(days, costs, index+1, days[index]+29, memo) + costs[2]; 
            
            memo[(index, daysCovered)] = GetMin(one, seven, thirty);
        }
        
        return memo[(index, daysCovered)];
    }
    
    public int MincostTickets(int[] days, int[] costs)
    {
        var memo = new Dictionary<(int, int), int>();
        return Helper(days, costs, 0, 0, memo);
    }
}
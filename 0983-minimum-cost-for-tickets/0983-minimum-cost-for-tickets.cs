public class Solution 
{
    private Dictionary<(int, int), int> memo;
    
    private int GetMin(int a, int b, int c) => Math.Min(Math.Min(a, b), c);
    
    public int MincostTickets(int[] days, int[] costs, int index = 0, int daysCovered = 0) 
    {
        if(memo == null) memo = new Dictionary<(int, int), int>();
        
        if(index >= days.Length) return 0;
        
        if(memo.ContainsKey((index, daysCovered))) return memo[(index, daysCovered)];
        
        if(daysCovered >= days[index]) 
            memo[(index, daysCovered)] = MincostTickets(days, costs, index+1, daysCovered);
        else
        {
            int one = MincostTickets(days, costs, index+1, days[index]) + costs[0];
            int seven = MincostTickets(days, costs, index+1, days[index]+6) + costs[1];
            int thirty = MincostTickets(days, costs, index+1, days[index]+29) + costs[2]; 
            
            memo[(index, daysCovered)] = GetMin(one, seven, thirty);
        }
        
        return memo[(index, daysCovered)];
    }
}
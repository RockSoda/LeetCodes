public class Solution 
{
    
    private int GetMin(int a, int b, int c) => Math.Min(Math.Min(a, b), c);
    
    private int Recurse(int[] days, int[] costs, int index, int daysCovered, Dictionary<(int, int), int> memo)
    {
        if(index >= days.Length) return 0;
        
        if(memo.ContainsKey((index, daysCovered))) return memo[(index, daysCovered)];
        
        if(daysCovered >= days[index]) 
            return memo[(index, daysCovered)] = Recurse(days, costs, index+1, daysCovered, memo);
        else
        {
            int one = Recurse(days, costs, index+1, days[index], memo) + costs[0];
            int seven = Recurse(days, costs, index+1, days[index]+6, memo) + costs[1];
            int thirty = Recurse(days, costs, index+1, days[index]+29, memo) + costs[2]; 
            
            return memo[(index, daysCovered)] = GetMin(one, seven, thirty);
        }
    }
    
    public int MincostTickets(int[] days, int[] costs) 
    {
        var memo = new Dictionary<(int, int), int>();
        return Recurse(days, costs, 0, 0, memo);
    }
}
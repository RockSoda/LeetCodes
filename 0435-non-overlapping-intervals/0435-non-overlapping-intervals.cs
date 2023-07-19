public class Solution 
{
    public int EraseOverlapIntervals(int[][] intervals) 
    {
        int count = 0;
        if (intervals.Length == 1) return count;
        
        var list = intervals.ToList();
        var sorted = list.OrderBy(x => x[0]).ThenBy(x => x[1]).ToArray();
        
        int lastEndTime = sorted[0][1];
        for(int i = 1; i < sorted.Length; i++)
        {
            var current = sorted[i];
            
            if(current[0] >= lastEndTime) lastEndTime = current[1];
            else
            {
                lastEndTime = Math.Min(lastEndTime, current[1]);
                count++;
            }
        }
        
        return count;
    }
}
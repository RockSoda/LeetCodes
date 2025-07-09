public class Solution 
{
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
    {
        int CheckTargetFreeTime(int targetFreeIndex)
        {
            if (targetFreeIndex == 0) return startTime[targetFreeIndex];
            
            if (targetFreeIndex == startTime.Length) return eventTime - endTime.Last();
            
            return startTime[targetFreeIndex] - endTime[targetFreeIndex - 1];
        }

        var result = 0;
        var curr = 0;

        for (var i = 0; i <= startTime.Length; i++)
        {
            curr += CheckTargetFreeTime(i);
            
            if (i < k) continue;
            
            result = Math.Max(result, curr);
            
            curr -= CheckTargetFreeTime(i - k);
        }
        
        return result;
    }
}
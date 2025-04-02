public class Solution 
{
    public long MaximumTripletValue(int[] nums) 
    {
        long maxEncountered = 0, maxDifference = 0, maxTriplet = 0;
        foreach(var num in nums)
        {
            maxTriplet = Math.Max(maxTriplet, maxDifference * num);
            maxDifference = Math.Max(maxDifference, maxEncountered - num);
            maxEncountered = Math.Max(maxEncountered, num);
        }
        return maxTriplet;
    }
}
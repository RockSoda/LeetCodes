public class Solution 
{
    public bool CheckSubarraySum(int[] nums, int k) 
    {
        var set = new HashSet<int>();
        int currSum = 0, prevSum = 0;
        
        foreach(var num in nums)
        {
            currSum += num;
            currSum %= k;
            
            if(set.Contains(currSum)) return true;
            
            set.Add(prevSum);
            prevSum = currSum;
        }
        
        return false;
    }
}
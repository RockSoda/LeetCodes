public class Solution 
{
    private List<int> GetZeroIntervals(List<int> nums)
    {
        int start = -1;
        
        var output = new List<int>();
        
        for(int i = 0; i < nums.Count; i++)
        {
            if(nums[i] == 0 && start == -1) start = i;
            
            else if(nums[i] != 0 && start != -1)
            {
                output.Add(i-start);
                start = -1;
            }
        }
        
        return output;
    }
    
    private long GetSum(int num)
    {
        long output = 0;
        
        for(int i = 1; i <= num; i++) output += i;
        
        return output;
    }
    
    public long ZeroFilledSubarray(int[] nums) 
    {
        var input = nums.ToList();
        input.Add(1);
        var zeroIntervals = GetZeroIntervals(input);
        
        var memo = new Dictionary<int, long>();
        long output = 0;
        foreach(var zeros in zeroIntervals)
        {
            if(!memo.ContainsKey(zeros)) memo[zeros] = GetSum(zeros);
            
            output += memo[zeros];
        }
        
        return output;
    }
}
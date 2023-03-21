public class Solution 
{
    private List<int> GetZeroIntervals(List<int> nums)
    {
        int start = -1;
        var output = new List<int>();
        for(int i = 0; i < nums.Count; i++)
        {
            if(nums[i] == 0 && start == -1)
            {
                start = i;
                continue;
            }
            
            if(nums[i] != 0 && start != -1)
            {
                output.Add(i-start);
                start = -1;
                continue;
            }
        }
        
        return output;
    }
    
    private long GetFactorial(int num)
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
        long output = 0;
        foreach(var zeros in zeroIntervals)
            output += GetFactorial(zeros);
        
        return output;
    }
}
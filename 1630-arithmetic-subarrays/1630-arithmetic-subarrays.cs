public class Solution 
{
    private int[] GetSubAry(int[] nums, int l, int r)
    {
        var ary = new int[r-l+1];
        int idx = 0;
        for(int i = l; i <= r; i++) ary[idx++] = nums[i];
        return ary;
    }
    
    private bool IsArithmetic(int[] nums)
    {
        if(nums.Length <= 1) return true;
        
        Array.Sort(nums);
        int diff = nums[1] - nums[0];
        for(int i = 2; i < nums.Length; i++)
        {
            if(nums[i] - nums[i-1] != diff) return false;
        }
        
        return true;
    }
    
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) 
    {
        var list = new List<bool>();
        for(int i = 0; i < l.Length; i++)
        {
            var ary = GetSubAry(nums, l[i], r[i]);
            list.Add(IsArithmetic(ary));
        }
        return list;
    }
}
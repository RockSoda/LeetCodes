public class Solution 
{
    public int CountMaxOrSubsets(int[] nums) 
    {
        var bitwiseOr = 0;
        foreach(var num in nums) bitwiseOr |= num;
        
        int n = nums.Length;
        int totalSubsets = 1 << n; // Equivalent to Math.Pow(2, n)
        int numOfSubsets = 0;
        for (int i = 0; i < totalSubsets; i++)
        {
            var currOr = 0;
            for (int j = 0; j < n; j++)
            {
                // Check if the j-th bit of 'i' is set
                if ((i & (1 << j)) != 0) currOr |= nums[j];
            }
            
            if(currOr == bitwiseOr) numOfSubsets++;
        }

        return numOfSubsets;
    }
}
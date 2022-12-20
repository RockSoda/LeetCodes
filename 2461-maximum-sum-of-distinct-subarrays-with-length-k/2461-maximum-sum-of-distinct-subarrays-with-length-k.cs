public class Solution 
{
    public long MaximumSubarraySum(int[] nums, int k) 
    {
        long sum = 0;
        long prevSum = 0;
        var set = new HashSet<int>();
        
        for(int i = 0; i < nums.Length-k+1; i++)
        {
            if(set.Count == 0)
            {
                bool flag = false;
                long currSum = 0;
                for(int j = i; j < k+i; j++)
                {
                    currSum += nums[j];
                    if(!set.Add(nums[j]))
                    {
                        set.Clear();
                        flag = true;
                        break;
                    }
                }
                if(flag) continue;
                
                prevSum = currSum;
                sum = Math.Max(sum, currSum);
            }
            else
            {
                int left = i;
                int right = i + k - 1;
                set.Remove(nums[left-1]);
                if(!set.Add(nums[right]))
                {
                    set.Clear();
                    continue;
                }
                
                long currSum = prevSum;
                currSum = currSum - nums[left-1] + nums[right];
                
                prevSum = currSum;
                sum = Math.Max(currSum, sum);
            }
        }
        
        return sum;
    }
}
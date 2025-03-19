public class Solution 
{
    public int MinOperations(int[] nums) 
    {
        void Flip(int idx)
        {
            nums[idx] = nums[idx] == 0 ? 1 : 0;
            nums[idx+1] = nums[idx+1] == 0 ? 1 : 0;
            nums[idx+2] = nums[idx+2] == 0 ? 1 : 0;
        }
        
        int ans = 0;

        for(int i = 0; i < nums.Length-2; i++)
        {
            if(nums[i] == 1) continue;

            Flip(i);

            ans++;
        }

        if(nums[nums.Length-1] == 0 || nums[nums.Length-2] == 0) return -1;

        return ans;
    }
}
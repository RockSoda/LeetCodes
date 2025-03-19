public class Solution 
{
    public int MinOperations(int[] nums) 
    {
        void Flip(int idx)
        {
            nums[idx] ^= 1;
            nums[idx+1] ^= 1;
            nums[idx+2] ^= 1;
        }

        int ans = 0;

        for(int i = 0; i < nums.Length-2; i++)
        {
            if(nums[i] == 1) continue;

            Flip(i);

            ans++;
        }

        return nums[^1] == 0 || nums[^2] == 0 ? -1 : ans;
    }
}
public class Solution 
{
    public int CountMaxOrSubsets(int[] nums) 
    {
        var bitwiseOr = 0;
        foreach(var num in nums) bitwiseOr |= num;
        var numOfSubsets = 0;

        void DFS(int idx, int currOr)
        {
            if(idx == nums.Length)
            {
                if(currOr == bitwiseOr) numOfSubsets++;
                return;
            }

            DFS(idx+1, currOr | nums[idx]);
            
            DFS(idx+1, currOr);
        }

        DFS(0, 0);

        return numOfSubsets;
    }
}
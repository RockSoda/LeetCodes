public class Solution 
{
    public int PartitionArray(int[] nums, int k) 
    {
        Array.Sort(nums);
        int counter = 1;
        int subSeqStarter = nums.First();
        for(int i = 1; i < nums.Length; i++)
        {
            var curr = nums[i];
            if(curr - subSeqStarter <= k) continue;
            subSeqStarter = curr;
            counter++;
        }
        return counter;
    }
}
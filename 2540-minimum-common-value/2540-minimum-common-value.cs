public class Solution 
{
    public int GetCommon(int[] nums1, int[] nums2) 
    {
        var set = nums1.ToHashSet();
        foreach(var num in nums2) 
            if(set.Contains(num)) return num;
        return -1;
    }
}
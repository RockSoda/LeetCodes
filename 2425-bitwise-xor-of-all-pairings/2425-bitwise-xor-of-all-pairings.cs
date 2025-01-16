public class Solution 
{
    public int XorAllNums(int[] nums1, int[] nums2) 
    {
        if(nums1.Length % 2 == 0 && nums2.Length % 2 == 0) return 0;
        
        int GetXor(int[] ary)
        {
            var num = ary.First();
            for(int i = 1; i < ary.Length; i++) num ^= ary[i];
            return num;
        }

        var output = 0;
        if(nums1.Length % 2 == 1) output ^= GetXor(nums2);
        if(nums2.Length % 2 == 1) output ^= GetXor(nums1);
        return output;
    }
}
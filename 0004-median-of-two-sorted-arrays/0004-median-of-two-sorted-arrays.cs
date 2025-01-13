public class Solution 
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        int index1 = 0, index2 = 0, totalIdx = 0, prevMid = -1, totalLen = nums1.Length + nums2.Length;
        bool isEven = totalLen % 2 == 0;

        while(index1 < nums1.Length || index2 < nums2.Length)
        {
            var curr = -1;

            if(index1 >= nums1.Length) curr = nums2[index2++];
            else if(index2 >= nums2.Length) curr = nums1[index1++];
            else
            {
                if(nums1[index1] < nums2[index2]) curr = nums1[index1++];
                else curr = nums2[index2++];
            }

            if(totalIdx == totalLen / 2 - 1) prevMid = curr;
            else if(totalIdx == totalLen / 2) return isEven ? (double)(prevMid + curr) / 2 : (double)curr;

            totalIdx++;
        }
        
        return -1;
    }
}
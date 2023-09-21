public class Solution 
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        var list = new List<int>();
        
        int index1 = 0;
        int index2 = 0;
        while(index1 < nums1.Length || index2 < nums2.Length)
        {
            if(index1 >= nums1.Length) list.Add(nums2[index2++]);
            else if(index2 >= nums2.Length) list.Add(nums1[index1++]);
            else
            {
                if(nums1[index1] < nums2[index2]) list.Add(nums1[index1++]);
                else list.Add(nums2[index2++]);
            }
        }
        
        return list.Count % 2 == 0 ? (double)(list[list.Count / 2]+list[list.Count / 2 - 1]) / 2 : (double)(list[list.Count / 2]);
    }
}
public class Solution 
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        var list = new List<int>();
        foreach(var n in nums1) list.Add(n);
        foreach(var n in nums2) list.Add(n);
        
        list.Sort();
        
        return list.Count % 2 == 0 ? (double)(list[list.Count / 2]+list[list.Count / 2 - 1]) / 2 : (double)(list[list.Count / 2]);
    }
}
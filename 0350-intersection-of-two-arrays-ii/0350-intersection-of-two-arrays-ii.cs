public class Solution 
{   
    public int[] Intersect(int[] nums1, int[] nums2) 
    {
        var map = new Dictionary<int, int>();
        foreach(var num in nums1) map[num] = map.ContainsKey(num) ? map[num]+1 : 1;
        
        var output = new List<int>();
        
        foreach(var num in nums2)
        {
            if(!map.ContainsKey(num)) continue;
            
            output.Add(num);
            if(--map[num] <= 0) map.Remove(num);
        }
        
        return output.ToArray();
    }
}
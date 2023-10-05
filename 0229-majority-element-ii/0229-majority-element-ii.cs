public class Solution 
{
    public IList<int> MajorityElement(int[] nums) 
    {
        var map = new Dictionary<int, int>();
        
        nums.ToList().ForEach(num => map[num] = map.ContainsKey(num) ? map[num]+1 : 1);
        
        var freq = nums.Length/3;
        
        return map.ToList().FindAll(kvp => kvp.Value > freq).Select(kvp => kvp.Key).ToList();
    }
}
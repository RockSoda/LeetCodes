public class Solution 
{
    public int[] SortByBits(int[] arr) 
    {
        int GetNumOfOneBits(int n)
        {
            var count = 0;
            while(n > 0)
            {
                count += (n&1);
                n >>= 1;
            }
            return count;
        }
        Array.Sort(arr);

        var map = new Dictionary<int, List<int>>();
        foreach(var num in arr)
        {
            var bits = GetNumOfOneBits(num);
            if(!map.ContainsKey(bits)) map[bits] = new List<int>();
            map[bits].Add(num);
        }

        var output = new List<int>();

        var keys = map.Keys.ToList();
        keys.Sort();
        foreach(var key in keys) output.AddRange(map[key]);

        return output.ToArray();
    }
}
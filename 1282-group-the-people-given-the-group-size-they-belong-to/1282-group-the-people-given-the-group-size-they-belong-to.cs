public class Solution 
{
    public IList<IList<int>> GroupThePeople(int[] groupSizes) 
    {
        var map = new Dictionary<int, List<int>>();
        for (int i = 0; i < groupSizes.Length; i++)
        {
            var groupSize = groupSizes[i];
            if (!map.ContainsKey(groupSize)) map[groupSize] = new List<int>();
            map[groupSize].Add(i);
        }
        
        var output = new List<IList<int>>();
        
        foreach(var kvp in map)
        {
            var chunks = kvp.Value.Chunk(kvp.Key);
            output.AddRange(chunks);
        }
        
        return output;
    }
}
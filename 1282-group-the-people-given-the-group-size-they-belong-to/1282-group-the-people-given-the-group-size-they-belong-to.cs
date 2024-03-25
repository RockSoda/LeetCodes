public class Solution 
{
    public IList<IList<int>> GroupThePeople(int[] groupSizes) 
    {
        var map = new Dictionary<int, List<IList<int>>>();
        for (int i = 0; i < groupSizes.Length; i++)
        {
            var groupSize = groupSizes[i];
            if (!map.ContainsKey(groupSize)) 
            {
                map[groupSize] = new List<IList<int>>();
                map[groupSize].Add(new List<int>());
            }
            
            var currList = map[groupSize].Last();
            if(currList.Count == groupSize)
            {
                map[groupSize].Add(new List<int>());
                currList = map[groupSize].Last();
            }
            currList.Add(i);
        }
        
        var output = new List<IList<int>>();
        
        foreach(var kvp in map) output.AddRange(kvp.Value);
        
        return output;
    }
}
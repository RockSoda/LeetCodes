public class Solution 
{
    public int[][] ReconstructQueue(int[][] people) 
    {
        var map = new SortedDictionary<int, List<int>>();
        
        foreach(var p in people)
        {
            if(!map.ContainsKey(p[0])) map[p[0]] = new List<int>();
            map[p[0]].Add(p[1]);
        }
        
        var keys = map.Keys.ToList();
        keys.Reverse();
        var output = new List<int[]>(new int[people.Length][]);
        foreach(var key in keys)
        {
            var indexes = map[key];
            indexes.Sort();
            foreach(var index in indexes) output.Insert(index, new int[]{key, index});
        }
        
        output.RemoveAll(x => x == null);
        
        return output.ToArray();
    }
}
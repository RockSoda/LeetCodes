public class Solution 
{
    public long DistinctNames(string[] ideas) 
    {
        var map = new Dictionary<char, HashSet<string>>();
        foreach(var idea in ideas)
        {
            if(!map.ContainsKey(idea[0])) map[idea[0]] = new HashSet<string>();
            
            map[idea[0]].Add(idea.Substring(1));
        }
        
        long output = 0;
        var values = map.Values.ToList();
        for(int i = 0; i < values.Count; i++)
        {
            var set1 = values[i];
            for(int j = i + 1; j < values.Count; j++)
            {
                var set2 = values[j];
                var mutual = set1.Count(x => set2.Contains(x));
                output += 2 * (set1.Count - mutual) * (set2.Count - mutual);
            }
        }
        
        return output;
    }
}
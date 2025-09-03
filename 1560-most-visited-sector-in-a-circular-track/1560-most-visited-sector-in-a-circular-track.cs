public class Solution 
{
    public IList<int> MostVisited(int n, int[] rounds) 
    {
        int GetNext(int curr)
        {
            var next = curr+1;
            if(next > n) return 1;
            return next;
        }

        var map = new Dictionary<int, int>();
        int max = -1;
        for(int i = 1; i < rounds.Length; i++)
        {
            var curr = rounds[i-1];
            while(curr != rounds[i])
            {
                map[curr] = map.ContainsKey(curr) ? map[curr]+1 : 1;
                max = Math.Max(map[curr], max);
                curr = GetNext(curr);
            }

            if(i < rounds.Length-1) continue;
            
            map[curr] = map.ContainsKey(curr) ? map[curr]+1 : 1;
            max = Math.Max(map[curr], max);
        }
        
        return map.Where(kvp => kvp.Value == max).OrderBy(kvp => kvp.Key).Select(kvp => kvp.Key).ToList();
    }
}
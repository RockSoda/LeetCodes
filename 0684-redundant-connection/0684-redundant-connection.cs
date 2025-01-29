public class Solution 
{
    public int[] FindRedundantConnection(int[][] edges) 
    {
        var map = new Dictionary<int, HashSet<int>>();
        foreach(var edge in edges)
        {
            var num0 = edge[0];
            var num1 = edge[1];
            if(!map.ContainsKey(num0)) map[num0] = new HashSet<int>();
            map[num0].Add(num1);

            if(!map.ContainsKey(num1)) map[num1] = new HashSet<int>();
            map[num1].Add(num0);
        }

        bool CanReach(int start, int end, HashSet<int> visited, Dictionary<(int, int), bool> memo)
        {
            if(!map.ContainsKey(start)) return false;
            if(map[start].Contains(end)) return true;
            if(visited.Contains(start)) return false;
            if(memo.ContainsKey((start, end))) return memo[(start, end)];

            visited.Add(start);
            bool isReached = false;
            foreach(var num in map[start])
            {
                isReached = isReached || CanReach(num, end, visited, memo);
            }
            return memo[(start, end)] = isReached;
        }

        void RemoveKeyVal(int num0, int num1)
        {
            map[num0].Remove(num1);
            if(map[num0].Count == 0) map.Remove(num0);

            map[num1].Remove(num0);
            if(map[num1].Count == 0) map.Remove(num1);
        }

        void AddKeyVal(int num0, int num1)
        {
            if(!map.ContainsKey(num0)) map[num0] = new HashSet<int>();
            map[num0].Add(num1);

            if(!map.ContainsKey(num1)) map[num1] = new HashSet<int>();
            map[num1].Add(num0);
        }

        for(int i = edges.Length - 1; i >= 0; i--)
        {
            var num0 = edges[i][0];
            var num1 = edges[i][1];

            RemoveKeyVal(num0, num1);
            if(CanReach(num0, num1, new HashSet<int>(), new Dictionary<(int, int), bool>())) return edges[i];
            AddKeyVal(num0, num1);
        }

        return null;
    }
}
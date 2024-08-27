public class Solution 
{
    public double MaxProbability(int n, int[][] edges, double[] succProbs, int start, int end) 
    {
        var map = new Dictionary<int, List<(int, double)>>();
        
        for(int i = 0; i < edges.Length; i++)
        {
            var edge = edges[i];
            var succProb = succProbs[i];
            
            if(!map.ContainsKey(edge[0])) map[edge[0]] = new List<(int, double)>();
            if(!map.ContainsKey(edge[1])) map[edge[1]] = new List<(int, double)>();
            
            map[edge[0]].Add((edge[1], succProb));
            map[edge[1]].Add((edge[0], succProb));
        }
        
        var bfs = new double[n];
        bfs[start] = 1;
        
        var que = new Queue<int>();
        que.Enqueue(start);
        
        while(que.Count > 0)
        {
            var curr = que.Dequeue();
            
            if(!map.ContainsKey(curr)) continue;
            
            foreach((var next, var prob) in map[curr])
            {
                var currProb = prob*bfs[curr];
                
                if(currProb <= bfs[next]) continue;
                
                bfs[next] = currProb;
                que.Enqueue(next);
            }
        }
        
        return bfs[end];
    }
}
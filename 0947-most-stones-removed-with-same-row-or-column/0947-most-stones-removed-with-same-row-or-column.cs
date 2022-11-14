public class Solution 
{
    private void Recurse(int[][] stones, bool[] visited, int prev, int start)
    {
        for(int i = 0; i < stones.Length; i++)
        {
            if(i == start || visited[i]) continue;
            
            if((stones[i][0] - stones[prev][0] == 0) != (stones[i][1] - stones[prev][1] == 0))
            {
                visited[i] = true;
                Recurse(stones, visited, i, start);
            }
        }
    }
    
    public int RemoveStones(int[][] stones) 
    {
        var visited = new bool[stones.Length];
        for(int i = 0; i < stones.Length; i++)
            if(!visited[i]) Recurse(stones, visited, i, i);
        
        return visited.Count(x => x);
    }
}
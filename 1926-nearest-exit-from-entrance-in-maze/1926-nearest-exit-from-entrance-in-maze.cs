public class Solution 
{
    public int NearestExit(char[][] maze, int[] entrance) 
    {
        var dx = new int[]{-1, 1, 0, 0};
        var dy = new int[]{0, 0, -1, 1};
        
        var q = new Queue<(int x, int y, int step)>();
        q.Enqueue((entrance[0], entrance[1], 0));
        
        var visited = new bool[maze.Length][];
        for(int i = 0; i < visited.Length; i++)
            visited[i] = new bool[maze[i].Length];
        
        while(q.Count > 0)
        {
            var curr = q.Dequeue();
            if((curr.x != entrance[0] || curr.y != entrance[1]) && (curr.x == 0 || curr.x == maze.Length-1 || curr.y == 0 || curr.y == maze[curr.x].Length-1)) return curr.step;
            
            for(int i = 0; i < 4; i++)
            {
                var x = curr.x + dx[i];
                var y = curr.y + dy[i];
                
                if(x < 0 || x >= maze.Length || y < 0 || y >= maze[x].Length || visited[x][y] || maze[x][y] == '+') continue;
                
                q.Enqueue((x, y, curr.step+1));
                visited[x][y] = true;
            }
        }
        
        return -1;
    }
}
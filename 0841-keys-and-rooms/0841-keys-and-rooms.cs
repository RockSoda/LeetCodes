public class Solution 
{
    private void Recurse(IList<IList<int>> rooms, bool[] visited, int current)
    {
        if(visited[current]) return;
        
        visited[current] = true;
        
        foreach(var key in rooms[current])
            Recurse(rooms, visited, key);
    }
    
    public bool CanVisitAllRooms(IList<IList<int>> rooms) 
    {
        var visited = new bool[rooms.Count];
        
        Recurse(rooms, visited, 0);
        
        return !visited.Any(x => !x);
    }
}
public class Solution 
{
    private void Recurse(IList<IList<int>> rooms, int key, bool[] visited)
    {
        if(key >= visited.Length || visited[key]) return;
        
        visited[key] = true;
        
        foreach(var cur in rooms[key])
            Recurse(rooms, cur, visited);
    }
    
    public bool CanVisitAllRooms(IList<IList<int>> rooms) 
    {
        var visited = new bool[rooms.Count];
        
        Recurse(rooms, 0, visited);
        
        return !visited.Any(x => !x);
    }
}
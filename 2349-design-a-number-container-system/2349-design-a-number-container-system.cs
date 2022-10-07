public class NumberContainers 
{
    private SortedDictionary<int, int> map;
    private Dictionary<int, int> history;
    public NumberContainers() 
    {
        map = new SortedDictionary<int, int>();
        history = new Dictionary<int, int>();
    }
    
    public void Change(int index, int number) 
    {
        if(map.ContainsKey(index) && history.ContainsKey(map[index]) && map.ContainsKey(index))
            history.Remove(map[index]);
        
        if(history.ContainsKey(number)) history.Remove(number);
        
        map[index] = number;
    }
    
    public int Find(int number) 
    {
        if(history.ContainsKey(number)) return history[number];
        
        foreach(var kvp in map)
            if(kvp.Value == number) return history[number] = kvp.Key;
        
        return history[number] = -1;
    }
}

/**
 * Your NumberContainers object will be instantiated and called as such:
 * NumberContainers obj = new NumberContainers();
 * obj.Change(index,number);
 * int param_2 = obj.Find(number);
 */
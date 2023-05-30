public class MyHashSet 
{
    private readonly int SIZE = ((int)Math.Pow(10, 6)) + 1;
    private bool[] _set;
    
    public MyHashSet() 
    {
        _set = new bool[SIZE];
    }
    
    public void Add(int key) 
    {
        _set[key] = true;
    }
    
    public void Remove(int key) 
    {
        _set[key] = false;
    }
    
    public bool Contains(int key) => _set[key];
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
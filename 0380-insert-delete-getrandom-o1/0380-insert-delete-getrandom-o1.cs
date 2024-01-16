public class RandomizedSet 
{
    private Random _rng;
    private HashSet<int> _set;
    
    public RandomizedSet() 
    {
        _set = new HashSet<int>();
        _rng = new Random();
    }
    
    public bool Insert(int val) => _set.Add(val);
    
    public bool Remove(int val) => _set.Remove(val);
    
    public int GetRandom() => _set.ToList()[_rng.Next(_set.Count)];
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
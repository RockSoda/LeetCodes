public class RandomizedSet 
{
    private Random rng;
    private HashSet<int> hSet;
    
    public RandomizedSet() 
    {
        hSet = new HashSet<int>();
        rng = new Random();
    }
    
    public bool Insert(int val) => hSet.Add(val);
    
    public bool Remove(int val) => hSet.Remove(val);
    
    public int GetRandom() =>
        hSet.ToList()[rng.Next(0, hSet.Count)];
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
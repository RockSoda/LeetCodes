public class MyHashMap 
{
    private int Size = (int)Math.Pow(10, 6) + 1;
    private int[] Map;
    
    public MyHashMap() 
    {
        Map = new int[Size];
        Array.Fill(Map, -1);
    }
    
    public void Put(int key, int value) 
    {
        Map[key] = value;
    }
    
    public int Get(int key) => Map[key];
    
    public void Remove(int key) 
    {
        Map[key] = -1;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
public class Solution 
{
    private void Recurse(int n, int x, List<int> list)
    {
        if(x > n) return;
        list.Add(x);
        Recurse(n, x*10, list);
        if(x % 10 < 9) Recurse(n, x+1, list);
    }
    
    public IList<int> LexicalOrder(int n) 
    {
        List<int> list = new List<int>();
        Recurse(n, 1, list);
        return list;
    }
}
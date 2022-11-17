public class Solution 
{
    private void DFS(int start, int k, int target, Stack<int> chosen, IList<IList<int>> res)
    {
        if (target == 0 && k == 0)
        {
            res.Add(chosen.ToList());
            return;
        }
        
        if (target <= 0 || k == 0) return;
        
        for (int i = start; i <= 9; i++)
        {
            chosen.Push(i);
            DFS(i + 1, k - 1, target - i, chosen, res);
            chosen.Pop();
        }
    }
    
    public IList<IList<int>> CombinationSum3(int k, int n) 
    {
        var res = new List<IList<int>>();
        DFS(1, k, n, new Stack<int>(), res);
        return res;
    }
}
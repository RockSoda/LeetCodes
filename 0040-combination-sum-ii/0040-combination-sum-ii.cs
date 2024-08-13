public class Solution 
{
    private void Recurse(int[] candidates, int target, int idx, List<int> list, List<IList<int>> output)
    {
        if(target < 0) return;
        
        if(target == 0) output.Add(list.ToList());
        
        for(int i = idx; i < candidates.Length; i++)
        {
            //Ensure there is no duplicated combinations
            if(i > idx && candidates[i] == candidates[i-1]) continue;
            
            list.Add(candidates[i]);
            Recurse(candidates, target-candidates[i], i+1, list, output);
            list.RemoveAt(list.Count - 1);
        }
    }
    
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) 
    {
        Array.Sort(candidates);
        var output = new List<IList<int>>();
        Recurse(candidates, target, 0, new List<int>(), output);
        return output;
    }
}
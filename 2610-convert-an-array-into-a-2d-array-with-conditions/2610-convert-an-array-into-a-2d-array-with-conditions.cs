public class Solution 
{
    public IList<IList<int>> FindMatrix(int[] nums) 
    {
        var list = new List<HashSet<int>>();
        
        foreach(var num in nums)
        {
            bool isAdded = false;
            
            foreach(var set in list)
            {
                if(set.Add(num))
                {
                    isAdded = true;
                    break;
                }
            }
            
            if(!isAdded) list.Add(new HashSet<int>{ num });
        }
        
        var output = new List<IList<int>>();
        foreach(var set in list) output.Add(set.ToList());
        
        return output;
    }
}
public class Solution 
{
    public IList<IList<int>> Subsets(int[] nums) 
    {
        var output = new List<IList<int>>();
        output.Add(new List<int>());
        foreach(var num in nums)
        {
            int len = output.Count;
            for(int i = 0; i < len; i++)
            {
                var tmp = new List<int>(output[i]);
                tmp.Add(num);
                output.Add(tmp);
            }
        }
        
        return output;
    }
}
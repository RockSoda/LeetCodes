public class Solution 
{
    public IList<string> SummaryRanges(int[] nums) 
    {
        var output = new List<string>();
        var stk = new Stack<int>();
        
        void AddToList()
        {
            if (stk.Count == 1) output.Add(stk.Pop().ToString());
            else
            {
                int right = stk.Pop();
                int left = stk.Pop();
                output.Add(left.ToString() + "->" + right.ToString());
            }
        }
        
        for(int i = 0; i < nums.Length; i++)
        {
            if (stk.Count > 0)
            {
                if (stk.Peek()+1 != nums[i]) AddToList();
                else if (stk.Count > 1) stk.Pop();
            }
            
            stk.Push(nums[i]);
        }
        
        if(stk.Count > 0) AddToList();
        
        return output;
    }
}
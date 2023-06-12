public class Solution 
{
    public IList<string> SummaryRanges(int[] nums) 
    {
        var output = new List<string>();
        var stk = new Stack<int>();
        
        void AddRange()
        {
            int right = stk.Pop();
            int left = stk.Pop();
            output.Add(left.ToString() + "->" + right.ToString());
        }
        
        void AddItem()
        {
            output.Add(stk.Pop().ToString());
        }
        
        for(int i = 0; i < nums.Length; i++)
        {
            if (stk.Count > 0)
            {
                if (stk.Peek()+1 == nums[i])
                {
                    if (stk.Count > 1) stk.Pop();
                }
                else if (stk.Count == 1) AddItem();
                else AddRange();
            }
            
            stk.Push(nums[i]);
        }
        
        if(stk.Count > 0)
        {
            if (stk.Count == 1) AddItem();
            else AddRange();
        }
        
        return output;
    }
}
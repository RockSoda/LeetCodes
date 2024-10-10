public class Solution 
{
    public int MaxWidthRamp(int[] nums) 
    {
        var pairs = new (int val, int idx)[nums.Length];
        for(int i = 0; i < nums.Length; i++) pairs[i] = (nums[i], i);

        pairs = pairs.OrderBy(pair => pair.val).ThenBy(pair => pair.idx).ToArray();

        var monoStk = new Stack<int>();
        int anchor = 0, width = -1;

        foreach((var val, var idx) in pairs)
        {
            while(monoStk.Count > 0 && monoStk.Peek() > idx) monoStk.Pop();

            if(monoStk.Count == 0) anchor = idx;
            
            monoStk.Push(idx);

            width = Math.Max(width, idx-anchor);
        }

        return width;
    }
}
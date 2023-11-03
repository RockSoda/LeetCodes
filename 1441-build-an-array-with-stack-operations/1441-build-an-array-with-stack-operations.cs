public class Solution 
{
    public IList<string> BuildArray(int[] target, int n) 
    {
        var output = new List<string>();
        int curr = 1;
        foreach(var num in target)
        {
            while(curr < num) 
            {
                output.Add("Push");
                output.Add("Pop");
                curr++;
            }
            
            output.Add("Push");
            curr++;
        }
        
        return output;
    }
}
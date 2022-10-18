public class Solution 
{
    public string CountAndSay(int n, string curr = "1") 
    {
        if(n <= 1) return curr;
        
        var sb = new StringBuilder();
        int counter = 1;
        for(int i = 1; i < curr.Length; i++)
        {
            if(curr[i] == curr[i-1]) counter++;
            else
            {
                sb.Append(counter.ToString());
                sb.Append(curr[i-1]);
                counter = 1;
            }
        }
        
        sb.Append(counter);
        sb.Append(curr.Last());
        
        return CountAndSay(n-1, sb.ToString());
    }
}
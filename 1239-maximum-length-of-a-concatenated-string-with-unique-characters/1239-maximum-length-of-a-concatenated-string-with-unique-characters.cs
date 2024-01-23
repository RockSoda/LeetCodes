public class Solution 
{
    private int max;
    private bool IsContainDup(string input)
    {
        var set = new HashSet<char>();
        return input.Any(x => !set.Add(x));
    }
    
    private void Recurse(IList<string> arr, int index, StringBuilder sb)
    {
        if(index >= arr.Count) return;
        
        Recurse(arr, index+1, sb);
        
        sb.Append(arr[index]);
        
        if(!IsContainDup(sb.ToString())) max = Math.Max(max, sb.Length);
        
        Recurse(arr, index+1, sb);
        
        sb.Remove(sb.Length - arr[index].Length, arr[index].Length);
    }
    
    public int MaxLength(IList<string> arr) 
    {
        max = 0;
        Recurse(arr, 0, new StringBuilder());
        return max;
    }
}
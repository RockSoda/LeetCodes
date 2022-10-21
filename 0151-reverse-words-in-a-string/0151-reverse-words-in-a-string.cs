public class Solution 
{
    public string ReverseWords(string s) 
    {
        var ary = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(ary);
        
        var sb = new StringBuilder();
        foreach(var word in ary) sb.Append(word + " ");
        sb.Remove(sb.Length - 1, 1);
        
        return sb.ToString();
    }
}
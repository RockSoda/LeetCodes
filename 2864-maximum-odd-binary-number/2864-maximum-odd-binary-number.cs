public class Solution 
{
    public string MaximumOddBinaryNumber(string s) 
    {
        var numOfOnes = s.Count(c => c == '1');
        var sb = new StringBuilder();
        
        sb.Append('1', numOfOnes - 1);
        sb.Append('0', s.Length - numOfOnes);
        sb.Append('1');
        
        return sb.ToString();
    }
}
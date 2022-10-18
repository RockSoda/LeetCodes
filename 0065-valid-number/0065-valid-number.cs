public class Solution 
{
    private System.Text.RegularExpressions.Regex RE = new System.Text.RegularExpressions.Regex(@"^(\s*[+-]?\d+\.?\d*[eE][+-]?\d+\s*)$|^(\s*[+-]?\d*\.?\d+[eE][+-]?\d+\s*)$|^(\s*[+-]?\d+\.?\d*\s*)$|^(\s*[+-]?\d*\.?\d+\s*)$");
    
    public bool IsNumber(string s) =>
        RE.IsMatch(s);
}
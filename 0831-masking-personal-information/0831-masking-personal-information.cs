public class Solution 
{
    private string MaskNumber(string s)
    {
        string input = s.Replace("+", "").Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");
        
        string lastFour = input.Substring(input.Length - 4);
        if(input.Length == 10) return new StringBuilder("***-***-" + lastFour).ToString();
        if(input.Length == 11) return new StringBuilder("+*-***-***-" + lastFour).ToString();
        if(input.Length == 12) return new StringBuilder("+**-***-***-" + lastFour).ToString();
        if(input.Length == 13) return new StringBuilder("+***-***-***-" + lastFour).ToString();
        
        return "";
    }
    
    private string MaskEmail(string s)
    {
        string[] emailArr = s.ToLower().Split('@');
        StringBuilder sb = new StringBuilder();
        sb.Append(emailArr[0].First());
        sb.Append("*****");
        sb.Append(emailArr[0].Last());
        sb.Append('@');
        sb.Append(emailArr[1]);
        return sb.ToString();
    }
    
    public string MaskPII(string s) => s.Contains('@') ? MaskEmail(s) : MaskNumber(s);
}
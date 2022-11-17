public class Solution 
{
    public bool AreNumbersAscending(string s) 
    {
        var prev = -1;
        for(int i = 0; i < s.Length; i++)
        {
            if(char.IsDigit(s[i]))
            {
                var sb = new StringBuilder();
                while(i < s.Length && char.IsDigit(s[i])) sb.Append(s[i++]);
                
                var num = int.Parse(sb.ToString());
                
                if(prev < num) prev = num;
                else return false;
            }
        }
        
        return true;
    }
}
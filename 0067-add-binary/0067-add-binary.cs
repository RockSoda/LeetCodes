public class Solution 
{
    private string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse( charArray );
        return new string( charArray );
    }
    
    public string AddBinary(string a, string b) 
    {
        var sb = new StringBuilder();
        a = Reverse(a);
        b = Reverse(b);
        
        int len = a.Length > b.Length ? a.Length : b.Length;
        
        bool isCarry = false;
        
        for(int i = 0; i < len; i++)
        {
            char ac = i >= a.Length ? '0' : a[i];
            char bc = i >= b.Length ? '0' : b[i];
            
            char curr = '-';
            if(ac == '1' || bc == '1')
            {
                if(ac == bc)
                {
                    curr = isCarry ? '1' : '0';
                    isCarry = true;
                }
                else curr = isCarry ? '0' : '1';
            }
            else
            {
                curr = isCarry ? '1' : '0';
                isCarry = false;
            }
            
            sb.Append(curr);
        }
        
        if(isCarry) sb.Append('1');
        
        return Reverse(sb.ToString());
    }
}
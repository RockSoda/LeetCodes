public class Solution 
{
    
    private string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse( charArray );
        return new string( charArray );
    }
    
    public IList<int> AddToArrayForm(int[] num, int k) 
    {
        var output = new List<int>();
        
        Array.Reverse(num);
        var strk = Reverse(k.ToString());
        
        int len = strk.Length > num.Length ? strk.Length : num.Length;
        
        bool isCarry = false;
        
        for(int i = 0; i < len; i++)
        {
            int a = i >= num.Length ? 0 : num[i];
            int b = i >= strk.Length ? 0 : strk[i]-'0';
            
            int curr = isCarry ? a+b+1 : a+b;
            
            isCarry = curr >= 10;
            if(isCarry) curr -= 10;
            
            output.Add(curr);
        }
        
        if(isCarry) output.Add(1);
        
        output.Reverse();
        return output;
    }
}
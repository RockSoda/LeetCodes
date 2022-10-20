public class Solution 
{
    private StringBuilder ConvertHelper(string first, string fifth, string tenth, int num)
    {
        var sb = new StringBuilder();
        
        if(num<4) for(int i = 0; i < num; i++) sb.Append(first);
        else if(num == 4) sb.Append(first + fifth);
        else if(num <9 && num >4)
        {
            num = num -5;
            sb.Append(fifth);
            for(int i = 0; i < num ; i++) sb.Append(first);
        }
        else if(num == 9) sb.Append(first + tenth);
        
        return sb;
    }
    
    private string Convert(int index, int num)
    {
        var output = new StringBuilder();
        
        if(index == 1) output = ConvertHelper("I", "V", "X", num);
        else if(index == 2) output = ConvertHelper("X", "L", "C", num);
        else if(index == 3) output = ConvertHelper("C", "D", "M", num);
        else if(index == 4) for(int i = 0; i < num; i++) output.Append("M");
        
        return output.ToString();
    }
    
    public string IntToRoman(int num) 
    {
        string strNum = num.ToString();
        var output = new StringBuilder();
        for(int i = strNum.Length-1; i >= 0; i--)
            output.Insert(0, Convert(strNum.Length-i, (int)(strNum[i]-'0')));
        
        return output.ToString();
    }
}
public class Solution 
{
    private StringBuilder ConvertHelper(char first, char fifth, char tenth, int num)
    {
        var sb = new StringBuilder();
        
        if (num < 4) sb.Append(first, num);
        else if (num == 4)
        {
            sb.Append(first);
            sb.Append(fifth);
        }
        else if (num < 9 && num > 4)
        {
            num -= 5;
            sb.Append(fifth);
            sb.Append(first, num);
        }
        else if (num == 9)
        {
            sb.Append(first);
            sb.Append(tenth);
        }
        
        return sb;
    }
    
    private string Convert(int index, int num)
    {
        var output = new StringBuilder();
        
        switch (index)
        {
            case 1:
                output = ConvertHelper('I', 'V', 'X', num);
                break;
            case 2:
                output = ConvertHelper('X', 'L', 'C', num);
                break;
            case 3:
                output = ConvertHelper('C', 'D', 'M', num);
                break;
            case 4:
                output.Append('M', num);
                break;
        }
        
        return output.ToString();
    }
    
    public string IntToRoman(int num) 
    {
        string strNum = num.ToString();
        var output = new StringBuilder();
        for (int i = strNum.Length - 1; i >= 0; i--)
            output.Insert(0, Convert(strNum.Length-i, (int)(strNum[i]-'0')));
        
        return output.ToString();
    }
}
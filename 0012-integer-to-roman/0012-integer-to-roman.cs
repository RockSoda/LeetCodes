public class Solution 
{
    private string Convert(int index, int num)
    {
        var output = new StringBuilder();
        if(index == 1)
        {
            if(num<4) for(int i = 0; i < num; i++) output.Append("I");
            else if(num == 4) output = new StringBuilder("IV");
            else if(num <9 && num >4)
            {
                num = num -5;
                output = new StringBuilder("V");
                for(int i = 0; i < num ; i++) output.Append("I");
            }else if(num == 9) output = new StringBuilder("IX");
        }
        else if(index == 2)
        {
            if(num<4) for(int i = 0; i < num; i++) output.Append("X");
            else if(num == 4) output = new StringBuilder("XL");
            else if(num <9 && num >4)
            {
                num = num -5;
                output = new StringBuilder("L");
                for(int i = 0; i < num ; i++) output.Append("X");
            }else if(num == 9) output = new StringBuilder("XC");
        }
        else if(index == 3)
        {
            if(num<4) for(int i = 0; i < num; i++) output.Append("C");
            else if(num == 4) output = new StringBuilder("CD");
            else if(num <9 && num >4)
            {
                num = num -5;
                output = new StringBuilder("D");
                for(int i = 0; i < num ; i++) output.Append("C");
            }else if(num == 9) output = new StringBuilder("CM");
        }else if(index == 4) for(int i = 0; i < num; i++) output.Append("M");
        
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
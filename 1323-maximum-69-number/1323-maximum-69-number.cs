public class Solution 
{
    public int Maximum69Number (int num) 
    {
        var chars = num.ToString().ToCharArray();
        for(int i = 0; i < chars.Length; i++)
        {
            if(chars[i] == '6')
            {
                chars[i] = '9';
                break;
            }
        }
        
        return int.Parse(new string(chars));
    }
}
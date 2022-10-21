public class Solution 
{
    private int ReverseInt(int num)
    {
        var charAry = num.ToString().ToCharArray();
        Array.Reverse(charAry);
        return int.Parse(new string(charAry));
    }
    
    public bool SumOfNumberAndReverse(int num) 
    {
        for(int i = 0; i <= num; i++)
        {
            if(i + ReverseInt(i) == num) return true;
        }
        
        return false;
    }
}
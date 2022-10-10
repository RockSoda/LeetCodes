public class Solution 
{
    public string BreakPalindrome(string palindrome) 
    {
        if(palindrome.Length == 1) return string.Empty;
        
        var charArry = palindrome.ToCharArray();
        for(int i =0; i < charArry.Length/2; i++) 
        {
            if(charArry[i] != 'a')
            {
                charArry[i] = 'a';
                return new string(charArry);
            }
        }
        
        charArry[charArry.Length - 1] = 'b';
        
        return new string(charArry);
    }
}
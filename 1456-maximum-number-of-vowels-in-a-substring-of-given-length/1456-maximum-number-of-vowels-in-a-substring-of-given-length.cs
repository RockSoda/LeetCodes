public class Solution 
{
    private bool IsVowel(char c)
    {
        switch(c)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                return true;
            default:
                return false;
        }
    }
    
    public int MaxVowels(string s, int k) 
    {
        var counter = 0;
        for(int i = 0; i < k; i++)
            if(IsVowel(s[i])) counter++;
        
        var max = counter;
        
        for(int i = k; i < s.Length; i++)
        {
            if(IsVowel(s[i-k])) counter--;
            if(IsVowel(s[i])) counter++;
            
            max = Math.Max(counter, max);
        }
        
        return max;
    }
}
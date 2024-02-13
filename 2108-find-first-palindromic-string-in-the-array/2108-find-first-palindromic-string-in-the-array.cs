public class Solution 
{   
    public string FirstPalindrome(string[] words) 
    {
        bool IsPalindrome(string str, int start, int end)
        {
            if(start >= end) return true;
            
            if(str[start] != str[end]) return false;
            
            return IsPalindrome(str, start+1, end-1);
        }
        
        foreach(var word in words)
            if(IsPalindrome(word, 0, word.Length-1)) return word;
        
        return string.Empty;
    }
}
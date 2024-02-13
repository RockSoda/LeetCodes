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
        
        bool IsPalindromeReverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return string.Compare(new string(charArray), str) == 0;
        }
        
        foreach(var word in words)
            if(IsPalindromeReverse(word)) return word;
        
        return string.Empty;
    }
}
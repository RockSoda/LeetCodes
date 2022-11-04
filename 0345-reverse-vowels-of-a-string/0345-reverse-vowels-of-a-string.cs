public class Solution 
{
    private bool IsVowel(char c) => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
    
    public string ReverseVowels(string s) 
    {
        var stk = new Stack<char>();
        foreach(var c in s) if(IsVowel(c)) stk.Push(c);
        
        var charAry = s.ToCharArray();
        for(int i = 0; i < s.Length; i++) if(IsVowel(charAry[i])) charAry[i] = stk.Pop();
        
        return new string(charAry);
    }
}
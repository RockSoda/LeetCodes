public class Solution 
{
    public string ReverseWords(string s) 
    {
        string[] strArr = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Array.Reverse(strArr);
        
        return string.Join(" ", strArr);
    }
}
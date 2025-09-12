public class Solution 
{
    public bool DoesAliceWin(string s) 
    {
        var vowelsSet = new HashSet<char>
        {
            'a', 'e', 'i', 'o', 'u'
        };
        
        foreach(var c in s)
        {
            if(vowelsSet.Contains(c)) return true;
        }
        
        return false;
    }
}
public class Solution 
{
    public bool DoesAliceWin(string s) 
    {
        var vowelsSet = new HashSet<char>
        {
            'a', 'e', 'i', 'o', 'u'
        };
        return s.Any(c => vowelsSet.Contains(c)) ? true : false;
    }
}
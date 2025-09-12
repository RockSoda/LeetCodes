public class Solution 
{
    public bool DoesAliceWin(string s) 
    {
        var vowelsSet = new HashSet<char>
        {
            'a', 'e', 'i', 'o', 'u'
        };

        var vowels = s.Count(c => vowelsSet.Contains(c));
        return vowels == 0 ? false : true;
    }
}
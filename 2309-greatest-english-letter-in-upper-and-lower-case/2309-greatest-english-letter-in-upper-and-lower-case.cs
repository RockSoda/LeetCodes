public class Solution 
{
    public string GreatestLetter(string s) 
    {
        var strSet = new HashSet<char>();
        var greatest = (char)('A'-1);

        foreach(var c in s)
        {
            strSet.Add(c);
            char lowerOrUpper = '-', upper = '-';
            if(c >= 'A' && c <= 'Z')
            {
                lowerOrUpper = (char)(c+32);
                upper = c;
            }
            else
            {
                lowerOrUpper = (char)(c-32);
                upper = lowerOrUpper;
            }

            if(strSet.Contains(lowerOrUpper) && greatest < upper) greatest = upper;
        }
        
        return greatest == (char)('A'-1) ? string.Empty : greatest.ToString();
    }
}
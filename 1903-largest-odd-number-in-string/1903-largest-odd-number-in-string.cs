public class Solution 
{
    public string LargestOddNumber(string num) =>
        num.Substring(0, num.ToList().FindLastIndex(c => (c-'0') % 2 == 1) + 1);
}
public class Solution 
{
    // Double the input string s
		// Then perform a search on doubled s
		// Search for s starting from index 1 of the doubled s
		// Returns true if the index found is not the length of s
		//Ex. s = "aba"
		//    ds = "abaaba"
		//    search index start from 1 and found s at 3
		//    return false
    public bool RepeatedSubstringPattern(string s) =>
        ((s + s).IndexOf(s, 1) != s.Count());
}
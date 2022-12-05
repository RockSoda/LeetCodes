public class Solution 
{
    public int RotatedDigits(int n) 
    {
        var set1 = new HashSet<int>{0, 1, 8};
        var set2 = new HashSet<int>{0, 1, 8, 2, 5, 6, 9};
        
        int counter = 0;
        for(int i = 1; i <= n; i++)
        {
            var curSet = new HashSet<int>();
            foreach(char c in i.ToString()) curSet.Add(c-'0');
            if(curSet.IsSubsetOf(set2) && !curSet.IsSubsetOf(set1)) counter++;
        }
        
        return counter;
    }
}
public class Solution 
{
    public int LongestCommonPrefix(int[] arr1, int[] arr2) 
    {
        void LoadSet(int num, HashSet<int> set)
        {
            var len = num.ToString().Length;
            var denominator = (int)Math.Pow(10, len-1);
            while(denominator >= 1)
            {
                set.Add(num / denominator);
                denominator /= 10;
            }
        }

        var set1 = new HashSet<int>();
        var set2 = new HashSet<int>();
        foreach(var num in arr1) LoadSet(num, set1);
        foreach(var num in arr2) LoadSet(num, set2);
        
        var intersection = set1.Count > set2.Count ? set1.Intersect(set2) : set2.Intersect(set1);
        return intersection.Count() == 0 ? 0 : intersection.Max(num => num.ToString().Length);
    }
}
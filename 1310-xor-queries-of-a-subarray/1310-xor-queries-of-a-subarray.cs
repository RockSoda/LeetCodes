public class Solution 
{
    public int[] XorQueries(int[] arr, int[][] queries) 
    {
        var prefixXOR = new int[arr.Length+1];
        for(int i = 1; i < prefixXOR.Length; i++) 
            prefixXOR[i] = prefixXOR[i-1] ^ arr[i-1];

        var output = new int[queries.Length];
        for(int i = 0; i < queries.Length; i++)
            output[i] = prefixXOR[queries[i][1] + 1] ^ prefixXOR[queries[i][0]];
        
        return output;
    }
}
public class Solution 
{
    public int[] ArrayRankTransform(int[] arr) 
    {
        var copied = arr.ToHashSet().ToArray();
        Array.Sort(copied);

        var map = new Dictionary<int, int>();
        for(int i = 0; i < copied.Length; i++) map[copied[i]] = i+1;

        var output = new int[arr.Length];
        for(int i = 0; i < arr.Length; i++) output[i] = map[arr[i]];

        return output;
    }
}
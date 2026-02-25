public class Solution 
{
    private string ToBin(int num) => Convert.ToString(num, 2);
    
    private int GetOccurance(string str, char c)
    {
        int counter = 0;
        foreach(char ch in str) if(ch == c) counter++;
        
        return counter;
    }
    
    public int[] SortByBits(int[] arr) 
    {
        Array.Sort(arr);
        var map = new SortedDictionary<int, List<int>>();
        
        foreach(int num in arr)
        {
            int numOfOnes = GetOccurance(ToBin(num), '1');
            if(map.ContainsKey(numOfOnes)) map[numOfOnes].Add(num);
            else map.Add(numOfOnes, new List<int>{ num });
        }
        
        var output = new int[arr.Length];
        
        int index = 0;
        foreach(var kvp in map)
        {
            foreach(int num in kvp.Value)
            {
                output[index] = num;
                index++;
            }
        }
        
        return output;
    }
}
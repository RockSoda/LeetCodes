public class Solution 
{
    public int HeightChecker(int[] heights) 
    {
        var expected = heights.ToArray();
        Array.Sort(expected);
        
        var counter = 0;
        for(int i = 0; i < heights.Length; i++)
        {
            if(heights[i] != expected[i]) counter++;
        }
        
        return counter;
    }
}
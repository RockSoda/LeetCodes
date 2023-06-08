public class Solution 
{
    public int CountNegatives(int[][] grid) 
    {
        
        int counter = 0;
        
        foreach(var row in grid)
            counter += row.Count(cell => cell < 0);
        
        return counter;
    }
}
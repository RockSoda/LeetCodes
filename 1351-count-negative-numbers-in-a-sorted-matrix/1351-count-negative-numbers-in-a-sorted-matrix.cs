public class Solution 
{
    private int GetIndex(int[] ary)
    {
        int left = 0, right = ary.Length-1;
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if(ary[mid] < 0)
            {
                if(mid - 1 < 0) return 0;
                
                if(ary[mid-1] < 0) right = mid - 1;
                else return mid;
            }
            else left = mid + 1;
        }
        
        return -1;
    }
    
    public int CountNegatives(int[][] grid) 
    {
        
        int counter = 0;
        
        foreach(var row in grid)
        {
            int index = GetIndex(row);
            
            if(index == -1) continue;
            
            counter += (row.Length - index);
        }
        
        return counter;
    }
}
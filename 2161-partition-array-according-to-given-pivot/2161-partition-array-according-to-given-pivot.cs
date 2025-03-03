public class Solution 
{
    public int[] PivotArray(int[] nums, int pivot) 
    {
        var less = new List<int>();
        var greater = new List<int>();
        int numOfPivot = 0;
        
        foreach(var num in nums)
        {
            if(num < pivot) less.Add(num);
            else if(num > pivot) greater.Add(num);
            else numOfPivot++;
        }

        less.AddRange(Enumerable.Repeat(pivot, numOfPivot));
        less.AddRange(greater);
        return less.ToArray();
    }
}
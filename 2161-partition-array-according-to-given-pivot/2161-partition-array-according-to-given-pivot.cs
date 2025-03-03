public class Solution 
{
    public int[] PivotArray(int[] nums, int pivot) 
    {
        int idxLess = 0, idxEqual = 0, idxGreater = 0;
        var list = new List<int>();
        foreach(var num in nums)
        {
            if(num > pivot)
            {
                list.Insert(idxGreater, num);
                idxGreater++;
            }
            else if(num == pivot)
            {
                list.Insert(idxEqual, num);
                idxEqual++;
                idxGreater++;
            }
            else
            {
                list.Insert(idxLess, num);
                idxLess++;
                idxEqual++;
                idxGreater++;
            }
        }
        return list.ToArray();
    }
}
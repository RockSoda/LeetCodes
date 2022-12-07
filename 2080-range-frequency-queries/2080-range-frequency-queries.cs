public class RangeFreqQuery 
{
    private Dictionary<int, List<int>> map;
    
    public RangeFreqQuery(int[] arr) 
    {
        map = new Dictionary<int, List<int>>();
        for(int i = 0; i < arr.Length; i++)
        {
            if(!map.ContainsKey(arr[i])) map[arr[i]] = new List<int>();
            
            map[arr[i]].Add(i);
        }
    }
    
    public int Query(int left, int right, int value)
    {
        return map.ContainsKey(value) ? SearchIndex(map[value], right, false) - SearchIndex(map[value], left, true) + 1 : 0;
    }
    
    private int SearchIndex(List<int> indexes, int target, bool isLeft)
    {
        int left = 0;
        int right = indexes.Count - 1;
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if(indexes[mid] > target) right = mid-1;
            else if(indexes[mid] < target) left = mid+1;
            else return mid;
        }
        
        return isLeft ? left : right;
    }
}

/**
 * Your RangeFreqQuery object will be instantiated and called as such:
 * RangeFreqQuery obj = new RangeFreqQuery(arr);
 * int param_1 = obj.Query(left,right,value);
 */
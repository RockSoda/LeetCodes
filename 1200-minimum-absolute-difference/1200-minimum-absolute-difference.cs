public class Solution 
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr) 
    {
        Array.Sort(arr);
        var minDiff = arr[1] - arr[0];
        var output = new List<IList<int>>();
        output.Add(new List<int>{ arr[0], arr[1] });
        
        for(int i = 2; i < arr.Length; i++)
        {
            var diff = arr[i] - arr[i-1];
            if(diff > minDiff) continue;

            if(diff < minDiff)
            {
                output.Clear();
                minDiff = diff;
            }
            
            output.Add(new List<int>{ arr[i-1], arr[i] });
        }

        return output;
    }
}
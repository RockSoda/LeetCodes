public class Solution 
{
    public IList<int> GetRow(int rowIndex) 
    {
        var map = new Dictionary<int, Dictionary<int, int>>();
        
        int Choose(int total, int choice)
        {
            if (total < choice) return 0;
            if (choice == 0 || choice == total) return 1;

            if (!(map.ContainsKey(total) && map[total].ContainsKey(choice)))
            {
                map[total] = new Dictionary<int, int>();
                map[total][choice] = Choose(total-1,choice-1)+Choose(total-1,choice);
            }
            
            return map[total][choice];
        }
        
        var output = new List<int>();
        
        for(int i = 0; i <= rowIndex; i++) output.Add(Choose(rowIndex,i));
        
        return output;
    }
}
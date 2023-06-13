public class Solution 
{
    public int EqualPairs(int[][] grid) 
    {
        Dictionary<int[], int> map = new Dictionary<int[], int>(new MyEqualityComparer());
        
        for(int i = 0; i < grid.Length; i++)
        {
            if(!map.ContainsKey(grid[i])) map.Add(grid[i].ToArray(), 0);
            
            map[grid[i]]++;
        }
        
        int counter = 0;
        
        for(int j = 0; j < grid[0].Length; j++)
        {
            var tmpList = new List<int>();
            for(int i = 0; i < grid.Length; i++) tmpList.Add(grid[i][j]);
            
            var tmpAry = tmpList.ToArray();
            if(map.ContainsKey(tmpAry)) counter += map[tmpAry];
        }
        
        return counter;
    }
}

public class MyEqualityComparer : IEqualityComparer<int[]>
{
    public bool Equals(int[] x, int[] y)
    {
        if (x.Length != y.Length)
        {
            return false;
        }
        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] != y[i])
            {
                return false;
            }
        }
        return true;
    }

    public int GetHashCode(int[] obj)
    {
        int result = 17;
        for (int i = 0; i < obj.Length; i++)
        {
            unchecked
            {
                result = result * 23 + obj[i];
            }
        }
        return result;
    }
}
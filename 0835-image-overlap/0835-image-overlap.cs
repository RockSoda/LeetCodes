public class Solution 
{
    public int LargestOverlap(int[][] img1, int[][] img2) 
    {
        var indexes1 = new List<(int x, int y)>();
        var indexes2 = new List<(int x, int y)>();
        
        for(int i = 0; i < img1.Length; i++)
        {
            for(int j = 0; j < img1[i].Length; j++)
            {
                if(img1[i][j] == 1) indexes1.Add((i, j));
                if(img2[i][j] == 1) indexes2.Add((i, j));
            }
        }
        
        var map = new Dictionary<(int, int), int>();
        foreach(var index1 in indexes1)
        {
            foreach(var index2 in indexes2)
            {
                var key = (index1.x - index2.x, index1.y - index2.y);
                map[key] = map.ContainsKey(key) ? map[key]+1 : 1;
            }
        }
        
        return map.Values.Count > 0 ? map.Values.Max() : 0;
    }
}
public class Solution 
{
    private (int, int) GetMinSteps(int num)
    {
        //x = No of 2
        //y = No of 3, = num/3
        
        //find min(x + y) = min[(x + num)/3]
        
        int x = 0;
        
        do
        {
            if(num % 3 == 0) return (x, num/3);
            num -= 2;
            x++;
        }
        while(num - 2 >= 0);
        
        return num == 0 ? (x, 0) : (-1, -1);
    }
    
    public int MinimumRounds(int[] tasks) 
    {
        var map = new Dictionary<int, int>();
        
        foreach(var task in tasks) map[task] = map.ContainsKey(task) ? map[task]+1 : 1;
        
        var steps = 0;
        
        foreach(var kvp in map)
        {
            (int x, int y) xNy = GetMinSteps(kvp.Value);
            
            if(xNy.x == -1 && xNy.y == -1) return -1;
            
            steps += xNy.x + xNy.y;
        }
        
        return steps;
    }
}
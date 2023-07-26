public class Solution 
{
    public int MinSpeedOnTime(int[] dist, double hour) 
    {
        if (hour <= dist.Length-1) return -1;
        
        double GetTime(int speed)
        {
            double time = 0;
            for (int i = 0; i < dist.Length-1; i++)
                time += Math.Ceiling((double)dist[i] / speed);
            
            time += (double)dist.Last() / speed;
            
            return time;
        }
        
        int left = 1, right = (int)Math.Pow(10,7);
        
        while(left <= right)
        {
            int mid = left + (right - left) / 2;
            
            double time = GetTime(mid);

            if (time < hour) right = mid-1;
            else if (time > hour) left = mid+1;
            else return mid;
        }
        
        return left;
    }
}
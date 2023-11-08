public class Solution 
{
    public bool IsReachableAtTime(int sx, int sy, int fx, int fy, int t) 
    {
        if (t == 1 && sx == fx && sy == fy) return false;
        var dist = Math.Max(Math.Abs(fy-sy), Math.Abs(fx-sx));
        return t >= dist;
    }
}
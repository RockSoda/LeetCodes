public class Robot 
{
    private int total;
    private int curr;
    private int x;
    private int y;
    private bool hasMoved;
    
    public Robot(int width, int height) 
    {
        curr = 0;
        x = width - 1;
        y = height - 1;
        total = 2 * (x + y);
        hasMoved = false;
    }
    
    public void Step(int num) 
    {
        hasMoved = true;
        curr = (curr + num) % total;
    }
    
    public int[] GetPos() 
    {
        if(curr <= x) return new int[]{ curr, 0 }; 
        else if(curr <= x + y) return new int[]{ x, curr - x };
        else if(curr <= 2 * x + y) return new int[]{ x - (curr - (x + y)), y };
        else return new int[]{ 0, y - (curr - (2 * x + y)) };
    }
    
    public string GetDir() 
    {
        if(!hasMoved) return "East";

        if(curr == 0) return "South";
        else if(curr <= x) return "East";
        else if(curr <= x + y) return "North";
        else if(curr <= 2 * x + y) return "West";
        else return "South";
    }
}

/**
 * Your Robot object will be instantiated and called as such:
 * Robot obj = new Robot(width, height);
 * obj.Step(num);
 * int[] param_2 = obj.GetPos();
 * string param_3 = obj.GetDir();
 */
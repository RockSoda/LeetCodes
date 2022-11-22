public class Solution 
{
    private int GetRCollisions(Stack<char> stk)
    {
        var counter = 0;
        while(stk.Count > 0 && stk.Peek() == 'R')
        {
            stk.Pop();
            counter++;
        }
        stk.Push('S');
        
        return counter;
    }
    
    public int CountCollisions(string directions) 
    {
        int collisions = 0;
        var stk = new Stack<char>();
        foreach(var c in directions)
        {
            if(c == 'L' && stk.Count > 0)
            {
                if(stk.Peek() == 'R')
                {
                    stk.Pop();
                    collisions += 2;
                    collisions += GetRCollisions(stk);
                }
                else if(stk.Peek() == 'S') collisions++;
            }
            else if(c == 'S' && stk.Count > 0)
                collisions += GetRCollisions(stk);
            else stk.Push(c);
        }
        
        return collisions;
    }
}
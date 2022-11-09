public class Solution 
{
    public bool JudgeCircle(string moves) 
    {
        int longitude = 0;
        int latitude = 0;
        
        foreach(var move in moves)
        {
            switch(move)
            {
                case 'U':
                    latitude++;
                    break;
                case 'D':
                    latitude--;
                    break;
                case 'L':
                    longitude--;
                    break;
                case 'R':
                    longitude++;
                    break;
                default:
                    break;
            }
        }
        
        return longitude == 0 && latitude == 0;
    }
}
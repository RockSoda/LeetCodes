public class Solution 
{
    public int RobotSim(int[] commands, int[][] obstacles) 
    {
        var obstacleSet = new HashSet<(int, int)>();
        foreach(var obstacle in obstacles) obstacleSet.Add((obstacle[0], obstacle[1]));
        
        (int, int)[] directions = { (0, 1), (1, 0), (0, -1), (-1, 0) };
        (int x, int y) currentPosition = (0, 0);
        int maxDistanceSquared = 0;
        int currentDirection = 0; // 0: North, 1: East, 2: South, 3: West

        foreach(var command in commands)
        {
            if(command == -1)
            {
                // Turn right
                currentDirection = (currentDirection + 1) % 4;
                continue;
            }
            
            if(command == -2)
            {
                // Turn left
                currentDirection = (currentDirection + 3) % 4;
                continue;
            }

            // Move forward
            (int x, int y) direction = directions[currentDirection];
            for (int step = 0; step < command; step++) 
            {
                int nextX = currentPosition.x + direction.x;
                int nextY = currentPosition.y + direction.y;
                if (obstacleSet.Contains((nextX, nextY))) break;
                currentPosition.x = nextX;
                currentPosition.y = nextY;
            }

            maxDistanceSquared = Math.Max(
                maxDistanceSquared,
                currentPosition.x * currentPosition.x +
                currentPosition.y * currentPosition.y
            );
        }
        return maxDistanceSquared;
    }
}
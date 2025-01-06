public class Solution 
{
    public int[] MinOperations(string boxes) 
    {

        var balls = new List<int>();
        for(int i = 0; i < boxes.Length; i++)
        {
            if(boxes[i] == '1') balls.Add(i);
        }

        int GetMoves(int idx)
        {
            var moves = 0;
            foreach(var ball in balls) moves += Math.Abs(ball - idx);
            
            return moves;
        }

        var output = new int[boxes.Length];
        for(int i = 0 ; i < boxes.Length; i++) output[i] = GetMoves(i);

        return output;
    }
}
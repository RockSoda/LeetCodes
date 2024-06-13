public class Solution 
{
    public int MinMovesToSeat(int[] seats, int[] students) 
    {
        Array.Sort(seats);
        Array.Sort(students);
        
        int moves = 0;
        for(int i = 0; i < seats.Length; i++) moves += Math.Abs(students[i] - seats[i]);
        
        return moves;
    }
}
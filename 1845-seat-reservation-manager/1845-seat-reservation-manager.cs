public class SeatManager 
{
    private bool[] isReserved;
    
    public SeatManager(int n) 
    {
        isReserved = new bool[n];
    }
    
    public int Reserve() 
    {
        int index = Array.IndexOf(isReserved, false);
        isReserved[index] = true;
        return index+1;
    }
    
    public void Unreserve(int seatNumber) 
    {
        isReserved[seatNumber-1] = false;
    }
}
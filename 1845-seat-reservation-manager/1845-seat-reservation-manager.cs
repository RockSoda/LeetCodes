public class SeatManager 
{
    private List<bool> isReserved;
    
    public SeatManager(int n) 
    {
        isReserved = new List<bool>(n);
        for(int i = 0; i < n; i++) isReserved.Add(false);
    }
    
    public int Reserve() 
    {
        int index = isReserved.IndexOf(false);
        isReserved[index] = true;
        return index+1;
    }
    
    public void Unreserve(int seatNumber) 
    {
        isReserved[seatNumber-1] = false;
    }
}
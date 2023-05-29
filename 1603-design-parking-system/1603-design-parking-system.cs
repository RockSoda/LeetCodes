public class ParkingSystem 
{
    private int[] _parkingLot;
    
    public ParkingSystem(int big, int medium, int small) 
    {
        _parkingLot = new int[3];
        _parkingLot[0] = big;
        _parkingLot[1] = medium;
        _parkingLot[2] = small;
    }
    
    public bool AddCar(int carType) =>
        _parkingLot[carType-1]-- > 0;
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */
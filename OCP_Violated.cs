public class FuelCalculator
{
    public double Calculate(string vehicleType)
    {
        if (vehicleType == "Truck")
            return 100;
        else if (vehicleType == "Bike")
            return 30;

        return 0;
    }
}

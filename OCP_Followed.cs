public abstract class Vehicle
{
    public abstract double CalculateFuel();
}

public class Truck : Vehicle
{
    public override double CalculateFuel() => 100;
}

public class Bike : Vehicle
{
    public override double CalculateFuel() => 30;
}

public class FuelCalculator
{
    public double Calculate(Vehicle vehicle)
    {
        return vehicle.CalculateFuel();
    }
}

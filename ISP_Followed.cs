public interface IDrivable
{
    void Drive();
}

public interface IFlyable
{
    void Fly();
}

public class Truck : IDrivable
{
    public void Drive()
    {
        Console.WriteLine("Truck driving");
    }
}

public class Drone : IDrivable, IFlyable
{
    public void Drive() { }
    public void Fly() { }
}

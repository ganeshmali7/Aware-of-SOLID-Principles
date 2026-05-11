public interface IVehicle
{
    void Drive();
    void Fly();
}

public class Truck : IVehicle
{
    public void Drive() { }

    public void Fly()
    {
        throw new Exception("Truck can't fly");
    }
}

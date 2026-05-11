public interface IVehicle
{
}

public interface IEngineVehicle : IVehicle
{
    void StartEngine();
}

public class Truck : IEngineVehicle
{
    public void StartEngine()
    {
        Console.WriteLine("Truck engine started");
    }
}

public class Bicycle : IVehicle
{
}

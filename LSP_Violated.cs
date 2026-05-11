public class Vehicle
{
    public virtual void StartEngine()
    {
        Console.WriteLine("Engine started");
    }
}

public class Bicycle : Vehicle
{
    public override void StartEngine()
    {
        throw new Exception("No engine!");
    }
}

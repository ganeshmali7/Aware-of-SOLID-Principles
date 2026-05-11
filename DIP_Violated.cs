public class GPSService
{
    public void GetLocation()
    {
        Console.WriteLine("Getting location...");
    }
}

public class Navigation
{
    private GPSService gps = new GPSService();

    public void Start()
    {
        gps.GetLocation();
    }
}

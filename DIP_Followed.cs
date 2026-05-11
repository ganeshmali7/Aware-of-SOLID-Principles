public interface ILocationService
{
    void GetLocation();
}

public class GPSService : ILocationService
{
    public void GetLocation()
    {
        Console.WriteLine("Getting GPS location...");
    }
}

public class Navigation
{
    private readonly ILocationService locationService;

    public Navigation(ILocationService locationService)
    {
        this.locationService = locationService;
    }

    public void Start()
    {
        locationService.GetLocation();
    }
}

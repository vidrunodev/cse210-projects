public class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public override string GenerateFullDetails()
    {
        return base.GenerateStandardDetails() + $"\nType: Outdoor Gathering\nWeather Forecast: {weatherForecast}";
    }
}

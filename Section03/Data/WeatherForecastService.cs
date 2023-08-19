namespace Section03.Data;

public class WeatherForecastService
{
    private readonly IConfiguration _configuration;
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public WeatherForecastService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public Task<WeatherForecast[]> GetForecastAsync(DateOnly startDate)
    {
        var days = _configuration.GetValue<int>("WeatherForecast:Days");
        return Task.FromResult(Enumerable.Range(1, days).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        }).ToArray());
    }
}

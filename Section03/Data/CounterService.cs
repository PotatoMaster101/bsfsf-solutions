namespace Section03.Data;

public class CounterService : ICounterService
{
    private readonly ILogger<CounterService> _logger;
    private int _count;

    public int Count
    {
        get => _count;
        set
        {
            _count = value;
            _logger.LogInformation("Count = {Count}", value);
        }
    }

    public CounterService(ILogger<CounterService> logger)
    {
        _logger = logger;
    }
}

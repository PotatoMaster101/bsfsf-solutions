namespace Section05.Models;

public class Username
{
    private string _displayName;

    public string FirstName { get; }
    public string LastName { get; }
    public readonly IReadOnlyList<string> DisplayNames;
    public string DisplayName
    {
        get => _displayName;
        set
        {
            if (DisplayNames.Contains(value))
                _displayName = value;
        }
    }

    public Username(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        DisplayNames = new[]
        {
            $"{firstName} {lastName}",
            $"{firstName}.{lastName}",
            $"{firstName[0]} {lastName}",
            $"{firstName[0]}.{lastName}"
        };
        _displayName = DisplayNames[0];
    }
}

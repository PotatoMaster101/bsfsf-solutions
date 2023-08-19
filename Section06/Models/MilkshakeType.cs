namespace Section06.Models;

public class MilkshakeType
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public MilkshakeType(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}

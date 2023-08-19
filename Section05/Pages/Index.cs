using Microsoft.AspNetCore.Components;
using Section05.Models;

namespace Section05.Pages;

public partial class Index
{
    private readonly Username[] _users = {
        new("John", "Smith"),
        new("John", "Brown"),
        new("John", "Williams")
    };

    [Inject]
    public ILogger<Index>? Logger { get; set; }

    private void NameChanged(string name)
    {
        Logger?.LogInformation("New name = {name}", name);
    }
}

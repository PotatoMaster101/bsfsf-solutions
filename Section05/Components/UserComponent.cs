using Microsoft.AspNetCore.Components;
using Section05.Models;

namespace Section05.Components;

public partial class UserComponent
{
    private bool _showNames;

    [Parameter]
    public Username? User { get; set; }

    [Parameter]
    public EventCallback<string> OnNameClick { get; set; }

    private void ToggleNames()
    {
        _showNames = !_showNames;
    }

    private Task SetNewDisplayName(string name)
    {
        if (User is null)
            return Task.CompletedTask;

        User.DisplayName = name;
        ToggleNames();
        return OnNameClick.InvokeAsync(name);
    }
}

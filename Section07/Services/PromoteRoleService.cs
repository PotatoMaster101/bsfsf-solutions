using Microsoft.AspNetCore.Identity;

namespace Section07.Services;

public class PromoteRoleService : IPromoteRoleService
{
    private readonly UserManager<IdentityUser> _userManager;

    public PromoteRoleService(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task PromoteAdmin(string userEmail)
    {
        var user = await _userManager.FindByEmailAsync(userEmail).ConfigureAwait(false);
        if (user is not null)
            await Promote(user, "admin").ConfigureAwait(false);
    }

    public async Task PromoteEmployee(string userEmail)
    {
        var user = await _userManager.FindByEmailAsync(userEmail).ConfigureAwait(false);
        if (user is not null)
            await Promote(user, "employee").ConfigureAwait(false);
    }

    private async Task Promote(IdentityUser user, string role)
    {
        var roles = await _userManager.GetRolesAsync(user).ConfigureAwait(false);
        if (!roles.Contains(role))
            await _userManager.AddToRoleAsync(user, role).ConfigureAwait(false);
    }
}

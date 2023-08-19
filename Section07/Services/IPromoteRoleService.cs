namespace Section07.Services;

public interface IPromoteRoleService
{
    Task PromoteAdmin(string userEmail);

    Task PromoteEmployee(string userEmail);
}

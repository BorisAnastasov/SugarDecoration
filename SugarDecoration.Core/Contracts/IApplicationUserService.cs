namespace SugarDecoration.Core.Contracts
{
    public interface IApplicationUserService
    {
        Task<string> UserFullName(string userId);
    }
}

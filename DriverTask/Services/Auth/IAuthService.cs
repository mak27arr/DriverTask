using DriverTask.Models;

namespace DriverTask.Services
{
    public interface IAuthService
    {
        Task Login(LoginRequest loginRequest);
        Task Logout();
        Task<CurrentUser> CurrentUserInfo();
    }
}

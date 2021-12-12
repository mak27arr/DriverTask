using DriverTask.Models;
using System.Net.Http.Json;

namespace DriverTask.Services
{
    internal class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<CurrentUser> CurrentUserInfo()
        {
            throw new NotImplementedException
        }
        public async Task Login(LoginRequest loginRequest)
        {
        }
        public async Task Logout()
        {
        }
    }
}

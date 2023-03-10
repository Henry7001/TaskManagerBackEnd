

using TaskManager.Contracts.Auth;
using TaskManager.Models;

namespace TaskManager.Services.Auth;
public interface IAuthService
{
    Task<User> Register(CreateUserRequest newUser);
    Task<LoginResponse> Login(LoginRequest data);
    // LoginResponse RenovarToken(string token);
}
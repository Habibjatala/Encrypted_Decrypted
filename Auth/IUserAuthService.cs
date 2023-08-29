using Encrypted_Decrypted.DTOs.User;
using Encrypted_Decrypted.Model;

namespace Encrypted_Decrypted.Auth
{
    public interface IUserAuthService
    {
        Task<ServiceResponse<int>> Register(UserRegistrationDto request);
        Task<ServiceResponse<UserAuthenticatedDto>> Login(String username, string password);
        Task<bool> UserExists(string username);
    }
}

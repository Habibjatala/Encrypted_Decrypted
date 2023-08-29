using Encrypted_Decrypted.DTOs.User;
using Encrypted_Decrypted.Model;

namespace Encrypted_Decrypted.Services.Services
{
    public interface IUserServices
    {
        Task<ServiceResponse<List<GetUserDto>>> GetAllUser();
    }
}

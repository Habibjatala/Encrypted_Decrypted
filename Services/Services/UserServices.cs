using Encrypted_Decrypted.Data;

namespace Encrypted_Decrypted.Services.Services
{
    public class UserServices
    {
        private readonly DataContext _context;
         public UserServices(DataContext context)
        {
            _context = context;
        }
    }
}

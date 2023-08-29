using Encrypted_Decrypted.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Encrypted_Decrypted.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<User> Users => Set<User>();
    }
}

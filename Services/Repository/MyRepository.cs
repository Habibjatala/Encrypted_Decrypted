using Encrypted_Decrypted.Data;
using Encrypted_Decrypted.Model;
using Microsoft.EntityFrameworkCore;

namespace Encrypted_Decrypted.Services.Repository
{
    public class MyRepository<TEntity> where TEntity : class
    {
        private readonly DataContext _context;
        public MyRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<TEntity> Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Get(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<ServiceResponse<List<TEntity>>> GetAll()
        {
            var entities = await _context.Set<TEntity>().ToListAsync();
            return new ServiceResponse<List<TEntity>> { Data = entities, Success = true };
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}

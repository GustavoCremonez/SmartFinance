using Microsoft.EntityFrameworkCore;
using SmartFinance.Domain.Contracts;
using SmartFinance.Domain.Entities;
using SmartFinance.Infra.Data.Context;

namespace SmartFinance.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<User?> GetUserAsync(int id)
        {
            User? entity = await _context.Users.Include(x => x.BankAccounts)
                                               .SingleOrDefaultAsync(u => u.Id == id);

            return entity;
        }

        public async Task CreateUserAsync(User entity)
        {
            await _context.Users.AddAsync(entity);
            _context.SaveChanges();
        }

        public async Task DeleteUserAsync(int id)
        {
            User entity = await GetUserAsync(id);

            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<User> UpdateUserAsync(User entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
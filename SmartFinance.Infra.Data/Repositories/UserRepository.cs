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
            User entity = await GetUserAsync(id) ?? throw new ApplicationException("Entity to remove was not found");

            _context.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<User> UpdateUserAsync(User entity)
        {
            User entidade = _context.Users.SingleOrDefault(x => x.Id == entity.Id) ?? throw new ApplicationException("Entity to update was not found");
            User updatedEntity = _context.Update(entidade).Entity;

            await _context.SaveChangesAsync();

            return updatedEntity;
        }
    }
}
﻿using SmartFinance.Domain.Entities;

namespace SmartFinance.Domain.Contracts
{
    public interface IUserService
    {
        Task<User?> GetUserAsync(int id);

        Task CreateUserAsync(User entity);

        Task DeleteUserAsync(int id);

        Task<User> UpdateUserAsync(User entity);
    }
}
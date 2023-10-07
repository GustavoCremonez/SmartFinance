using SmartFinance.Application.DTOs;
using SmartFinance.Domain.Contracts;
using SmartFinance.Domain.Entities;

namespace SmartFinance.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> GetUserAsync(int id)
        {
            User? user = await _userRepository.GetUserAsync(id);

            if (user != null)
            {
                UserDto userDto = new UserDto()
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    Birthdate = user.Birthdate,
                    Password = user.Password,
                    Phone_number = user.Phone_number
                };
            }

            return user;
        }

        public async Task CreateUserAsync(User entity)
        {
            await _userRepository.CreateUserAsync(entity);
        }

        public async Task DeleteUserAsync(int id)
        {
            await _userRepository.DeleteUserAsync(id);
        }

        public async Task<User> UpdateUserAsync(User entity)
        {
            return await _userRepository.UpdateUserAsync(entity);
        }
    }
}
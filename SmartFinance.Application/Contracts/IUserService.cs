using SmartFinance.DTO.DTOs;

namespace SmartFinance.Application.Contracts
{
    public interface IUserService
    {
        Task<UserDto?> GetUserAsync(int id);

        Task CreateUserAsync(UserDto entity);

        Task DeleteUserAsync(int id);

        Task<UserDto> UpdateUserAsync(UserDto entity);
    }
}
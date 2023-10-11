using AutoMapper;
using SmartFinance.Application.Contracts;
using SmartFinance.Domain.Contracts;
using SmartFinance.Domain.Entities;
using SmartFinance.DTO.DTOs;

namespace SmartFinance.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserDto?> GetUserAsync(int id)
        {
            User? user = await _userRepository.GetUserAsync(id);

            return _mapper.Map<UserDto?>(user);
        }

        public async Task CreateUserAsync(UserDto userDto)
        {
            await _userRepository.CreateUserAsync(_mapper.Map<User>(userDto));
        }

        public async Task DeleteUserAsync(int id)
        {
            await _userRepository.DeleteUserAsync(id);
        }

        public async Task<UserDto> UpdateUserAsync(UserDto userDto)
        {
            User entity = _mapper.Map<User>(userDto);

            return _mapper.Map<UserDto>(await _userRepository.UpdateUserAsync(entity));
        }
    }
}
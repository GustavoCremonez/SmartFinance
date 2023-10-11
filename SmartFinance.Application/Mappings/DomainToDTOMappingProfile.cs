using SmartFinance.Domain.Entities;
using SmartFinance.DTO.DTOs;
using AutoMapper;

namespace SmartFinance.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
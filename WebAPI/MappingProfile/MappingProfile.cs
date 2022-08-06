using AutoMapper;
using Domain.DataTransferObjects;
using Domain.Entities;

namespace WebAPI.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Owner, OwnerDto>();
        }
    }
}
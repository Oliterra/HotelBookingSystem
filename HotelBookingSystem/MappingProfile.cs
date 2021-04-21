using AutoMapper;
using Business.DTO;
using Business.Models;

namespace WebAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HotelModel, Hotel>();
        }
    }
}

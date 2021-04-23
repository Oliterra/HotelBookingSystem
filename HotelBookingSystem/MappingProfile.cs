using AutoMapper;
using Business.Models;
using Business.ViewModels;

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

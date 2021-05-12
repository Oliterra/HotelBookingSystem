using AutoMapper;
using Business.Models;
using Business.ViewModels;
using Database.Entities;

namespace WebAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HotelModel, Hotel>();

            CreateMap<HotelSearchRequestModel, HotelsSearchModel>();

            CreateMap<HotelEntity, HotelModel>();

            CreateMap<RoomEntity, RoomModel>();
        }
    }
}

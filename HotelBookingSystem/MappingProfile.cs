using AutoMapper;
using Business.Models;
using Business.ViewModels;
using Business.ViewModels.RoomBooking;
using Database.Entities;

namespace WebAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HotelModel, Hotel>().ReverseMap();

            CreateMap<HotelEntity, HotelModel>().ReverseMap();

            CreateMap<Hotel, HotelsSearchModel>().ReverseMap();

            CreateMap<RoomEntity, RoomModel>();
        }
    }
}

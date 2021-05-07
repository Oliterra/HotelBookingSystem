using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Models;
using Business.ViewModels;

namespace Business.Interfaces
{
    public interface IHotelService
    {
        Task AddHotel(HotelModel hotel);
        Task<HotelModel> GetHotel(Guid id);
        Task DeleteHotel(Guid id);
        Task UpdateHotel(Guid id, HotelModel hotel);
    }
}

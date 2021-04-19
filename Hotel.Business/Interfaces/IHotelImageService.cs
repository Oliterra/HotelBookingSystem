using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IHotelImageService
    {
        HotelImageModel GetHotelImageById(Guid hotelImageId);

        bool AddHotelImage (HotelImageModel hotelImage);

        bool UpdateHotelImage(HotelImageModel hotelImage);

        bool DeleteHotelImage(Guid hotelImageId);
    }
}

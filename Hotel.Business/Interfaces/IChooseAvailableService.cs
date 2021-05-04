using System;
using System.Collections.Generic;
using System.Text;
using Business.Models;

namespace Business.Interfaces
{
    public interface IChooseAvailableService
    {
        List<HotelModel> GetAvailableHotels();

        List<RoomModel> GetAvailableRooms();
    }
}

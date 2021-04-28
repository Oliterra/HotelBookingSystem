using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database.Entities;

namespace Database.Interfaces
{
    public interface IHotelsSearchRepository
    {
        IQueryable<HotelEntity> GetHotels();
    }
}

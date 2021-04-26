using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Entities;

namespace Database.Interfaces
{
    public interface ISearchingRepository
    {
        IQueryable<HotelEntity> GetHotels();
    }
}

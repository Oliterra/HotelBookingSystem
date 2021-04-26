using System.Linq;
using Database.Entities;

namespace Database.Interfaces
{
    public interface IHotelsSearchRepository
    {
        IQueryable<HotelEntity> GetHotels();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Business.Models;

namespace Business.Interfaces
{
    public interface IHotelsSearchService
    {
        List<HotelModel> Find(HotelsSearchModel searchModel);
    }
}

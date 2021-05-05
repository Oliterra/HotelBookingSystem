using System;
using System.Collections.Generic;
using System.Text;
using Business.Models;

namespace Business.Interfaces
{
    public interface IRoomParametres
    {
        List<RoomModel> SelectRoom (RoomSearchModel searchModel);
    }
}

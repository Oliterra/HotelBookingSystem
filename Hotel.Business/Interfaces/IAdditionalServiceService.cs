using Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IAdditionalServiceService    
    {
        AdditionalServiceModel GetAdditionalServiceById(Guid addServId);

        bool AddAdditionalService (AdditionalServiceModel addServ);

        bool UpdateAdditionalService (AdditionalServiceModel addServ);

        bool DeleteAdditionalService (Guid addServId);
    }
}

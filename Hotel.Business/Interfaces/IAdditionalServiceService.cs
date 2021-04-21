using Business.Models;
using System;

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

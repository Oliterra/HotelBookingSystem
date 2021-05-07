using Business.Models;
using System;
using System.Threading.Tasks;
using Business.ViewModels;

namespace Business.Interfaces
{
    public interface IAdditionalServiceService    
    {
        Task AddAdditionalService(AdditionalServiceModel addServ);
        Task<AdditionalServiceModel> GetAdditionalService(Guid id);
        Task DeleteAdditionalService(Guid id);
        Task UpdateAdditionalService(Guid id, AdditionalServiceModel addServ);
    }
}

using Business.Interfaces;
using Business.Models;
using Database.Entities;
using Database.Interfaces;
using System;

namespace Business.Services
{
    public class AdditionalServiceService : IAdditionalServiceService
    {
        private readonly IAdditionalServiceRepository _additionalServiceRepository;

        public AdditionalServiceService (IAdditionalServiceRepository additionalServiceRepository)
        {
            _additionalServiceRepository = additionalServiceRepository;
        }

        public bool AddAdditionalService(AdditionalServiceModel addServ)
        {
            if (addServ == null)
            {
                throw new NullReferenceException("Additional service is null");
            }
            return _additionalServiceRepository.Add(Mapper.Map<AdditionalServiceModel, AdditionalServiceEntity>(addServ));
        }

        public bool DeleteAdditionalService(Guid addServId)
        {
            if (addServId == null)
            {
                throw new NullReferenceException("Additional service id is incorrect");
            }
            return _additionalServiceRepository.Delete(addServId);
        }

        public AdditionalServiceModel GetAdditionalServiceById(Guid addServId)
        {
            if (addServId == null)
            {
                throw new NullReferenceException("Id is incorrect");
            }
            return Mapper.Map<AdditionalServiceEntity, AdditionalServiceModel>(_additionalServiceRepository.GetById(addServId));
        }

        public bool UpdateAdditionalService(AdditionalServiceModel addServ)
        {
            if (addServ == null)
            {
                throw new NullReferenceException("Additional service is null");
            }
            return _additionalServiceRepository.Update(Mapper.Map<AdditionalServiceModel, AdditionalServiceEntity>(addServ));
        }
    }
}

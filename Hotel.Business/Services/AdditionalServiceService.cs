using AutoMapper;
using Business.Models;
using Database.Entities;
using Database.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;

namespace Business.Services
{
    public class AdditionalServiceService : IAdditionalServiceService
    {
        private readonly IHotelSystemRepository<AdditionalServiceEntity> _addServRepository;
        private readonly IMapper _mapper;

        public AdditionalServiceService(IHotelSystemRepository<AdditionalServiceEntity> addServRepository, IMapper mapper)
        {
            _addServRepository = addServRepository;
            _mapper = mapper;
        }

        public async Task AddAdditionalService(AdditionalServiceModel addServ)
        {
            await _addServRepository.Create(_mapper.Map<AdditionalServiceEntity>(addServ));
        }

        public async Task<AdditionalServiceModel> GetAdditionalService(Guid id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Id is incorrect");
            }

            return _mapper.Map<AdditionalServiceEntity, AdditionalServiceModel>(await _addServRepository.FindById(id));
        }

        public async Task DeleteAdditionalService(Guid id)
        {
            AdditionalServiceModel additionalService = _mapper.Map<AdditionalServiceModel>(await _addServRepository.FindById(id));

            if (additionalService == null)
            {
                throw new NullReferenceException("Additional service is null");
            }

            await _addServRepository.Delete(_mapper.Map<AdditionalServiceEntity>(additionalService));
        }

        public async Task UpdateAdditionalService(Guid id, AdditionalServiceModel updatedAdditionalService)
        {
            AdditionalServiceModel additionalService = _mapper.Map<AdditionalServiceModel>(await _addServRepository.FindById(id));

            if (additionalService == null)
            {
                throw new NullReferenceException("Additional service is null");
            }

            additionalService = UpdateAdditionalServiceOptions(additionalService, updatedAdditionalService);

            await _addServRepository.Update(_mapper.Map<AdditionalServiceEntity>(additionalService));
        }

        private AdditionalServiceModel UpdateAdditionalServiceOptions(AdditionalServiceModel addServ, AdditionalServiceModel updatedAddServ)
        {
            addServ.Id = updatedAddServ.Id;
            addServ.Name = updatedAddServ.Name;
            addServ.Description = updatedAddServ.Description;
            addServ.Cost = updatedAddServ.Cost;
            return addServ;
        }
    }
}

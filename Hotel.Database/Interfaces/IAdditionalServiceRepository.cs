using Database.Entities;
using System;
using System.Linq;

namespace Database.Interfaces
{
    public interface IAdditionalServiceRepository
    {
        IQueryable<AdditionalServiceEntity> GetQueryable();

        AdditionalServiceEntity GetById(Guid addServId);

        bool Add(AdditionalServiceEntity addServ);

        bool Update(AdditionalServiceEntity addServ);

        bool Delete(Guid addServId);
    }
}

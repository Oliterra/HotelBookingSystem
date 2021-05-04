using System;
using System.Linq;
using Database.Entities;

namespace Database.Interfaces.CRUD
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

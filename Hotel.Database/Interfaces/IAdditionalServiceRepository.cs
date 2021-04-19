using Hotel.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

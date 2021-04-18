using Hotel.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database.Interfaces
{
    interface IAdditionalServiceRepository
    {
        IQueryable<AdditionalServiceEntity> GetQueryable();
        AdditionalServiceEntity GetById(Guid addServId);
        void Add(AdditionalServiceEntity addServ);
        void Update(AdditionalServiceEntity addServ);
        void Delete(Guid addServId);
    }
}

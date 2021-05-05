using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Interfaces
{
    public interface ISuperAdminService
    {
        Task CreateAdminOwner(Guid id);
        Task DeleteAdminOwner(Guid id);
    }
}

using Business.ViewModels.Authorization.Account;
using System.Threading.Tasks;
using Business.ViewModels.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Interfaces
{
    public interface ITokenService
    {
        TokenOptions GenerateToken();
    }
}

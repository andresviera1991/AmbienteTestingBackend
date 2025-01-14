using MGP.Authentication.Domain.Models;
using MGP.Authentication.Persistance.Data.Tables;
using System;
using System.Threading.Tasks;

namespace MGP.Authentication.Domain.Interfaces
{
    public interface IJwtTokenGenerator
    {
        Task<TokenResponse> GenerateSessionTokenAsync(User user);
        Task<string> GenerateEmailTokenAsync(Guid userId);
    }
}
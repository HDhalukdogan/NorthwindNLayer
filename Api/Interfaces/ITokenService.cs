using Api.Entities;

namespace Api.Interfaces
{
    public interface ITokenService
    {
        Task<string> GenerateToken(AppUser user);
    }
}

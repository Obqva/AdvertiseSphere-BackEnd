using Obqva.Domain.Entities;

namespace Obqva.Service.Services
{
    public interface IAdService
    {
        Task<Ad> GetAdById (int id);

        Task<Ad> GetAdByTitle (string title);
    }
}

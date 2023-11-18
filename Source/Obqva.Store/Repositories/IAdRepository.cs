using Obqva.Domain.Entities;

namespace Obqva.Store.Repositories
{
    public interface IAdRepository
    {
        Task<Ad?> GetByIdAsync(int id);

        Task<Ad?> GetByTitleAsync(string title);
    }
}

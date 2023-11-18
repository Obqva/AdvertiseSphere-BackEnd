using Obqva.Domain.Entities;
using Obqva.Store.Repositories;

namespace Obqva.Service.Services
{
    public class AdService : IAdService
    {
        private readonly IAdRepository _repository;

        public AdService(IAdRepository repository)
        {
            _repository = repository;
        }

        public async Task<Ad> GetAdById(int id)
        {
            var ad = await _repository.GetByIdAsync(id);

            return ad == null ? throw new Exception("Ad with this ID is not found") : ad;
        }

        public async Task<Ad> GetAdByTitle(string title)
        {
            var ad = await _repository.GetByTitleAsync(title);

            return ad == null ? throw new Exception("Ad with this Title is not found") : ad;
        }
    }
}

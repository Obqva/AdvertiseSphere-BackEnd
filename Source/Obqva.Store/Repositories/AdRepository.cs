using Microsoft.EntityFrameworkCore;
using Obqva.Domain.Entities;

namespace Obqva.Store.Repositories
{
    public class AdRepository : IAdRepository
    {
        private readonly AdvertiseSphereDbContext _dbContext;

        public AdRepository(AdvertiseSphereDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Ad?> GetByIdAsync(int id)
        {
            return await _dbContext.Ad.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Ad?> GetByTitleAsync(string title)
        {
            return await _dbContext.Ad.FirstOrDefaultAsync(x =>x.Title == title);
        }
    }
}

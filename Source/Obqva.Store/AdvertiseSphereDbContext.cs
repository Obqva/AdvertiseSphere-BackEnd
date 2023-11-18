using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Obqva.Domain.Entities;

namespace Obqva.Store
{
    public class AdvertiseSphereDbContext: DbContext
    {
        public AdvertiseSphereDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Ad> Ad => Set<Ad>();
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Obqva.Domain.Entities;

namespace Obqva.Store
{
    public class AdDbContext: DbContext
    {
        public AdDbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<Ad> Ad => Set<Ad>();
    }
}

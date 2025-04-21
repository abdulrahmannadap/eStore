using eStore.Application.common.Interfaces;
using eStore.Domain.Entity;
using eStore.Infrastructure.Data;

namespace eStore.Infrastructure.Repository
{
    public class TargetAudienceRepository : Repository<TargetAudience>, ITargetAudienceRepository
    {
        private readonly ApplicationDbContext _db;

        public TargetAudienceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(TargetAudience entity)
        {
            _db.Update(entity);
        }
    }
}

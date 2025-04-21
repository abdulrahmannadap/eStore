using eStore.Domain.Entity;

namespace eStore.Application.common.Interfaces
{
    public interface ITargetAudienceRepository : IRepository<TargetAudience>
    {
        void Update(TargetAudience entity);
    }
}

using eStore.Domain.Entity;

namespace eStore.Application.common.Interfaces
{
    public interface IBatchRepository : IRepository<Batch>
    {
        void Update(Batch batch);

    }
}

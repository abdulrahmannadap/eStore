using eStore.Domain.Entity;

namespace eStore.Application.common.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        void Update(Order order);
    }
}

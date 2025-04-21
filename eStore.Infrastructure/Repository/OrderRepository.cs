using eStore.Application.common.Interfaces;
using eStore.Domain.Entity;
using eStore.Infrastructure.Data;

namespace eStore.Infrastructure.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderRepository(ApplicationDbContext db) : base(db) { _db = db; }

        public void Update(Order order)
        {
            _db.Orders.Update(order);
        }
    }
}

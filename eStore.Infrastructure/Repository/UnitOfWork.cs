using eStore.Application.common.Interfaces;
using eStore.Infrastructure.Data;

namespace eStore.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public IProductRepository ProductRepositoryUOW { get; private set; }
        public IBatchRepository BatchRepositoryUOW { get; private set; }
        public ITargetAudienceRepository TargetAudienceRepositoryUOW { get; private set; }
        public IOrderRepository OrderRepositoryUOW { get; private set; }
        public IApplicationUserRepository ApplicationUserRepositoryUOW { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            this.ProductRepositoryUOW = new ProductRepository(_db);
            this.BatchRepositoryUOW = new BatchRepository(_db);
            this.TargetAudienceRepositoryUOW = new TargetAudienceRepository(_db);
            this.OrderRepositoryUOW = new OrderRepository(_db);
            this.ApplicationUserRepositoryUOW = new ApplicationUserRepository(_db);

        }
        public void Save()
        {
            try
            {
                using (_db.Database.BeginTransaction())
                {

                }
            }
            catch (Exception)
            {
                _db.Dispose();
                throw;
            }
            _db.SaveChanges();
        }
    }
}

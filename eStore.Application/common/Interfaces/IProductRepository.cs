using eStore.Domain.Entity;

namespace eStore.Application.common.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}

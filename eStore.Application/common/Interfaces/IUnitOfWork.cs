namespace eStore.Application.common.Interfaces
{
    public interface IUnitOfWork
    {
        public IProductRepository ProductRepositoryUOW { get; }
        public IBatchRepository BatchRepositoryUOW { get; }
        public ITargetAudienceRepository TargetAudienceRepositoryUOW { get; }
        public IOrderRepository OrderRepositoryUOW { get; }
        public IApplicationUserRepository ApplicationUserRepositoryUOW { get; }
        void Save();
    }
}

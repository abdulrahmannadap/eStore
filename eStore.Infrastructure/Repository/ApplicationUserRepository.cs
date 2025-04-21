using eStore.Application.common.Interfaces;
using eStore.Domain.Entity;
using eStore.Infrastructure.Data;

namespace eStore.Infrastructure.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _Db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db) { _Db = db; }


    }
}

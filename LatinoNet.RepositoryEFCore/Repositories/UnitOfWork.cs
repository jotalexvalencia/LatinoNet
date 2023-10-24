using LatinoNet.RepositoryEFCore.DataContext;
using LatinoNET.Entities.Interfaces;
using System.Threading.Tasks;

namespace LatinoNet.RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly LatinoNetContext Context;

        public UnitOfWork(LatinoNetContext context) =>
            Context = context;
        

        public Task<int> SaveChanges()
        {
            return Context.SaveChangesAsync();
        }
    }
}

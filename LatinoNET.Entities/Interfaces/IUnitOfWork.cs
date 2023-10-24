using System.Threading.Tasks;

namespace LatinoNET.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> SaveChanges();
    }
}

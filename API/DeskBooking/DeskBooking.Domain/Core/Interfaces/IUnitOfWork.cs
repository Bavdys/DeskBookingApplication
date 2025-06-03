using DeskBooking.Domain.Core.Models;
using System;
using System.Threading.Tasks;

namespace DeskBooking.Domain.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity, TIEntity> Repository<TEntity, TIEntity>() where TEntity : BaseEntity<TIEntity>;
        Task<int> Complete();
    }
}

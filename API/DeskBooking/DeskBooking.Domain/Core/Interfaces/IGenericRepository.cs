using DeskBooking.Domain.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DeskBooking.Domain.Core.Interfaces
{
    public interface IGenericRepository<T,IT> where T:BaseEntity<IT>
    {
        Task<T> GetByIdAsync(IT id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        Task<IReadOnlyList<T>> GetAsync(ISpecification<T> spec);
    }
}

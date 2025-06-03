using DeskBooking.Domain.Core.Interfaces;
using DeskBooking.Domain.Core.Models;
using DeskBooking.Infrastructure.Data;
using System;
using System.Collections;
using System.Threading.Tasks;

namespace DeskBooking.Infrastructure.Core.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private Hashtable _repositories;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IGenericRepository<TEntity, TIEntity> Repository<TEntity, TIEntity>() where TEntity : BaseEntity<TIEntity>
        {
            if(_repositories == null)
            {
                _repositories = new Hashtable();
            }

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<,>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity), typeof(TIEntity)), _context);
                _repositories.Add(type, repositoryInstance);
            }

            return (IGenericRepository<TEntity, TIEntity>)_repositories[type];
        }
    }
}

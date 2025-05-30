using DeskBooking.Domain.Core.Interfaces;
using DeskBooking.Domain.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DeskBooking.Infrastructure.Core.Specification
{
    public class SpecificationEvaluator<TEntity,TIEntity> where TEntity:BaseEntity<TIEntity>
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> spec)
        {
            var query = inputQuery;
            if(spec.Criteria!= null)
            {
                query = query.Where(spec.Criteria);
            }

            query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));

            query = spec.IncludeStrings.Aggregate(query, (current, include) => current.Include(include));

            return query;
        }
    }
}

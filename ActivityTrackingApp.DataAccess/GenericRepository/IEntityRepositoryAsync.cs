using System.Linq.Expressions;
using ActivityTrackingApp.Entities.BaseEntity;
using Microsoft.EntityFrameworkCore.Query;

namespace ActivityTrackingApp.Core.DataAccess;
public interface IEntityRepositoryAsync<T> where T : class, IEntity, new()
{
	Task<T> GetAsync(int id);

	Task<T> GetAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);

	Task<IList<T>> GetListAsync(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes);

	Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includes);

	Task AddAsync(T entity);

	Task UpdateAsync(T entity);

	Task RemoveAsync(T entity);
}

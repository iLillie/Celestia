using System.Linq.Expressions;
using Celestia.Models.Abstractions;

namespace Celestia.Data;

public interface IRepository<TEntity> where TEntity : class, new ()
{
    
    
    Task<TEntity?> GetAsync(int id, string auth0Id, bool ignoreAutoInclude = false);
    Task<TEntity?> FindAsync(Expression<Func<TEntity, bool>> predicate); 
    
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<IEnumerable<TEntity>> GetWhereAsync(Expression<Func<TEntity, bool>> predicate);

    Task AddAsync(TEntity entity);
    Task AddRangeAsync(IEnumerable<TEntity> entities);
    
    void Update(TEntity entity);
    void UpdateRange(IEnumerable<TEntity> entities);
    
    void Delete(TEntity entity);
    void DeleteRange(IEnumerable<TEntity> entities);
}
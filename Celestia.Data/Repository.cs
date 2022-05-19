using System.Linq.Expressions;
using Celestia.Models.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Celestia.Data;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : OwnedModel, new ()
{
    private readonly ApplicationDbContext _context;

    public Repository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<TEntity?> GetAsync(int id, bool ignoreAutoInclude = false)
    {
        return ignoreAutoInclude ? 
            await _context.Set<TEntity>().IgnoreAutoIncludes().FirstOrDefaultAsync(e => e.Id == id) 
            : await _context.Set<TEntity>().FindAsync(id);
    }
      

    public async Task<TEntity?> FindAsync(Expression<Func<TEntity, bool>> predicate)
        => await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);

    public async Task<IEnumerable<TEntity>> GetAllAsync()
        => await _context.Set<TEntity>().OrderBy(l => l.Id).ToListAsync();

    public async Task<IEnumerable<TEntity>> GetWhereAsync(Expression<Func<TEntity, bool>> predicate)
        => await _context.Set<TEntity>().Where(predicate).OrderBy(l => l.Id).ToListAsync();

    public async Task AddAsync(TEntity entity)
        => await _context.Set<TEntity>().AddAsync(entity);


    public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        => await _context.Set<TEntity>().AddRangeAsync(entities);
  

    public void Update(TEntity entity)
     => _context.Set<TEntity>().Update(entity);
    

    public void UpdateRange(IEnumerable<TEntity> entities)
        => _context.Set<TEntity>().UpdateRange(entities);
    

    public void Delete(TEntity entity)
        => _context.Set<TEntity>().Remove(entity);

    public void DeleteRange(IEnumerable<TEntity> entities)
     =>  _context.Set<TEntity>().RemoveRange(entities);
}
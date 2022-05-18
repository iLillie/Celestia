using Celestia.Models;

namespace Celestia.Data;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        JobRepository = new Repository<Job>(_context);
        CompanyRepository = new Repository<Company>(_context);
        ContactRepository = new Repository<Contact>(_context);
        FolderRepository = new Repository<Folder>(_context);
    }
    
    public IRepository<Job> JobRepository { get; }
    public IRepository<Company> CompanyRepository { get; }
    public IRepository<Contact> ContactRepository { get; }
    public IRepository<Folder> FolderRepository { get; }

    public async Task<bool> Complete()
        => await _context.SaveChangesAsync() > 0;

    public void Dispose()
        => _context.Dispose();
}
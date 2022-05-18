using Celestia.Models;

namespace Celestia.Data;

public interface IUnitOfWork : IDisposable
{
    IRepository<Job> JobRepository { get;  }
    IRepository<Company> CompanyRepository { get;  }
    IRepository<Contact> ContactRepository { get;  }
    IRepository<Folder> FolderRepository { get;  }
    Task<bool> Complete();
}
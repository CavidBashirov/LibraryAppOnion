using Domain.Models;

namespace Repository.Repositories.Interfaces
{
    public interface ILibraryRepository:IBaseRepository<Library>
    {
        Library GetByPhone(string phone);
    }
}

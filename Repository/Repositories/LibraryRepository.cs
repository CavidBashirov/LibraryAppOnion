using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories
{
    public class LibraryRepository : BaseRepository<Library>, ILibraryRepository
    {
        public Library GetByPhone(string phone)
        {
            return AppDbContext<Library>.datas.FirstOrDefault(m => m.Phone == phone);
        }
    }
}

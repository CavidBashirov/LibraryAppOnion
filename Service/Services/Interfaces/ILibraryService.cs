using Domain.Models;

namespace Service.Services.Interfaces
{
    public interface ILibraryService
    {
        void Create(Library data);
        void Delete(int? id);
        void Edit(Library data);
        Library GetById(int? id);
        List<Library> GetAll();
        List<Library> SearchByName(string searchText);
        Library GetByPhone(string phone);
    }
}

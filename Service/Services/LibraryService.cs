using Domain.Models;
using Repository.Data;
using Repository.Repositories;
using Repository.Repositories.Interfaces;
using Service.Helpers.Constants;
using Service.Helpers.Exceptions;
using Service.Services.Interfaces;

namespace Service.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly ILibraryRepository _libraryRepo;
        private int count = 1;

        public LibraryService()
        {
            _libraryRepo = new LibraryRepository();
        }

        public void Create(Library data)
        {
            if (data is null) throw new ArgumentNullException();
            data.Id = count;
            _libraryRepo.Create(data);
            count++;
        }

        public void Delete(int? id)
        {
            if(id is null) throw new ArgumentNullException();

            Library library = _libraryRepo.GetById((int)id);

            if (library is null) throw new NotFoundException(ResponseMessages.DataNotFound);

            _libraryRepo.Delete(library);
            
        }

        public void Edit(Library data)
        {
            throw new NotImplementedException();
        }

        public List<Library> GetAll()
        {
            return _libraryRepo.GetAll();
        }

        public Library GetById(int? id)
        {
            if (id is null) throw new ArgumentNullException();

            Library library = _libraryRepo.GetById((int)id);

            if (library is null) throw new NotFoundException(ResponseMessages.DataNotFound);

            return library;
        }

        public Library GetByPhone(string phone)
        {
            throw new NotImplementedException();
        }

        public List<Library> SearchByName(string searchText)
        {
            throw new NotImplementedException();
        }
    }
}

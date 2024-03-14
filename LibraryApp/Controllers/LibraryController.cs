using Domain.Models;
using Service.Helpers.Extensions;
using Service.Services;
using Service.Services.Interfaces;

namespace LibraryApp.Controllers
{
    internal class LibraryController
    {
        private readonly ILibraryService _libraryService;

        public LibraryController()
        {
            _libraryService = new LibraryService();
        }

        public void Create()
        {
            ConsoleColor.Cyan.WriteConsole("Add name:");
            Name: string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                ConsoleColor.Red.WriteConsole("Input can't be empty");
                goto Name;
            }

            ConsoleColor.Cyan.WriteConsole("Add capacity:");
            Capacity: string capacityStr = Console.ReadLine();
            int capacity;
            bool isCorrectCapacityFormat = int.TryParse(capacityStr, out capacity);

            if (isCorrectCapacityFormat)
            {
                ConsoleColor.Cyan.WriteConsole("Add phone number:");
                string phone = Console.ReadLine();

                try
                {

                    _libraryService.Create(new Library { Name = name, Capacity = capacity, Phone = phone});

                    ConsoleColor.Green.WriteConsole("Data successfully added");
                }
                catch (Exception ex)
                {
                    ConsoleColor.Red.WriteConsole(ex.Message);
                    goto Name;
                }

            }
            else
            {
                ConsoleColor.Red.WriteConsole("Capacity format is wrong, please add operation again");
                goto Capacity;
            }

          

        }
        
        public void GetAll()
        {
            var response = _libraryService.GetAll();

            foreach (var item in response)
            {
                string data = $"Id: {item.Id}, Library name : {item.Name}, Library capacity : {item.Capacity}, Library phone : {item.Phone}";
                Console.WriteLine(data);
            }
        }
    
        public void Delete()
        {
            ConsoleColor.Cyan.WriteConsole("Add library id:");
            Id: string idStr = Console.ReadLine();
            int id;
            bool isCorrectIdFormat = int.TryParse(idStr, out id);
            if (isCorrectIdFormat)
            {
                try
                {
                    _libraryService.Delete(id);
                    ConsoleColor.Green.WriteConsole("Data successfully deleted");
                }
                catch (Exception ex)
                {
                    ConsoleColor.Red.WriteConsole(ex.Message);
                    goto Id;
                }
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Id format is wrong, please add again");
                goto Id;
            }
        }
    }
}


using LibraryApp.Controllers;
using Service.Helpers.Enums;
using Service.Helpers.Extensions;



LibraryController libraryController = new();


while (true)
{
    GetMenues();
    Operation: string operationStr = Console.ReadLine();

    int operation;

    bool isCorrectOperationFormat = int.TryParse(operationStr, out operation);

    if (isCorrectOperationFormat)
    {
        switch (operation)
        {
            case (int)OperationType.LibraryCreate:
                libraryController.Create();
                break;

            case (int)OperationType.LibraryDelete:
                libraryController.Delete();
                break;

            case (int)OperationType.GetAllLibraries:
                libraryController.GetAll();
                break;
            default:
                ConsoleColor.Red.WriteConsole("Operation is wrong, please choose again");
                goto Operation;
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Operation format is wrong, please add operation again");
        goto Operation;
    }

   






}












static void GetMenues()
{
    ConsoleColor.Cyan.WriteConsole("Choose one operation :  1-Library create, 2-Library delete, 3-Get all libraries, 4-Edit library");
}

